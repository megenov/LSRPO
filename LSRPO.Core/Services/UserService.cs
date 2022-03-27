using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace LSRPO.Core.Services.User
{
    public class UserService : IUserService
    {
        private readonly IApplicatioDbRepository repo;
        private readonly IWebHostEnvironment webHostEnvironment;

        //private readonly ApplicationDbContext dbContext;

        public UserService(IApplicatioDbRepository repo, IWebHostEnvironment webHostEnvironment) //ApplicationDbContext dbContext
        {
            this.repo = repo;
            this.webHostEnvironment = webHostEnvironment;
            //this.dbContext = dbContext;
        }

        public async Task<(bool result, string error)> ChangePin(ChangePinViewModel model)
        {
            bool result = false;
            string error = "Възникна грешка!";
            NOT_USER_PIN? pinCode = null;
            var existPin = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.USR_PIN == model.PinCode);
            var user = await repo.All<AUTH_USER>().Where(w => w.Id == model.UserId).Include(i => i.NOT_USER_PIN).FirstOrDefaultAsync(); //.GetByIdAsync<AUTH_USER>(model.UserId);

            if (user != null)
            {
                if (existPin != null)
                {
                    pinCode = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.USR_ID == user.Id);

                    if (pinCode == null || existPin.USR_PIN != pinCode.USR_PIN)
                    {
                        return (result, "Този ПИН код вече се използва!");
                    }

                    return (result, "ПИН кода е същият като предишният!");
                }

                pinCode = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.USR_ID == user.Id);

                if (pinCode != null)
                {
                    if (pinCode.USR_PIN != model.PinCode)
                    {
                        pinCode.USR_PIN = model.PinCode;

                        try
                        {
                            await repo.SaveChangesAsync();
                            result = true;
                        }
                        catch (Exception)
                        {
                            error = "Неуспешен запис на промените в Базата данни";
                        }
                    }
                }

                else
                {
                    pinCode = new NOT_USER_PIN { USR_PIN = model.PinCode, USR_ID = model.UserId, AUTH_USER = user };

                    try
                    {
                        await repo.AddAsync<NOT_USER_PIN>(pinCode);
                        await repo.SaveChangesAsync();
                        result = true;
                    }
                    catch (Exception)
                    {
                        error = "Неуспешен запис на промените в Базата данни";
                    }
                }
            }

            return (result, error);
        }

        public async Task<(bool result, string error)> DeletePinCode(int pinId)
        {
            bool result = false;
            var error = string.Empty;

            var pinCode = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.NOT_USR_ID == pinId);
            //var pinCode2 = await dbContext.NOT_USERS_PIN.FirstOrDefaultAsync(f => f.NOT_USR_ID == pinId);

            if (pinCode == null)
            {
                return (result, "Този потребител няма ПИН код!");
            }

            try
            {
                //dbContext.NOT_USERS_PIN.Remove(pinCode2);
                //await dbContext.SaveChangesAsync();

                //repo.Delete<NOT_USER_PIN>(pinCode);

                await repo.DeleteAsync<NOT_USER_PIN>(pinId);
                await repo.SaveChangesAsync();
                result = true;
            }
            catch (Exception)
            {
                error = "Неуспешен запис на промените в Базата данни";
            }

            return (result, error);
        }

        public async Task<bool> DeleteUserPin(int id)
        {
            bool result = true;
            var pinCode = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.USR_ID == id);

            if (pinCode == null)
            {
                return result;
            }

            try
            {
                //repo.Delete<NOT_USER_PIN>(pinCode);
                await repo.DeleteAsync<NOT_USER_PIN>(pinCode.NOT_USR_ID);
                await repo.SaveChangesAsync();
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public async Task<ChangePinViewModel> GetPinCode(int id)
        {
            var pinCode = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.USR_ID == id);

            if (pinCode == null)
            {
                return new ChangePinViewModel { UserId = id };
            }

            return new ChangePinViewModel { UserId = id, PinCode = pinCode.USR_PIN };
        }

        public async Task<IEnumerable<PinCodesViewModel>> GetPinCodes()
        {
            return await repo.All<AUTH_USER>()
                .Select(s => new PinCodesViewModel
                {
                    Id = s.Id,
                    PinId = s.NOT_USER_PIN.NOT_USR_ID,
                    UserName = s.UserName,
                    FullName = s.USR_FULLNAME,
                    PinCode = s.NOT_USER_PIN.USR_PIN
                })
                .ToListAsync();
        }

        public async Task<UserProfileViewModel> GetUserForProfileEdit(int id)
        {
            var user = await repo.GetByIdAsync<AUTH_USER>(id);

            return new UserProfileViewModel { Id = user.Id, UserName = user.UserName, FullName = user.USR_FULLNAME, Image = user.IMAGE_URL };
        }

        public async Task<IEnumerable<UserListViewModel>> GetUsers()
        {
            return 
                await repo.All<AUTH_USER>()
                .Select(s => 
                new UserListViewModel 
                { 
                    Id = s.Id, 
                    UserName = s.UserName, 
                    FullName = s.USR_FULLNAME, 
                    RegDate = s.USR_REG_DATE != null ? s.USR_REG_DATE.Value.ToString("dd/MM/yyyy, HH:mm:ss", CultureInfo.InvariantCulture) : "n/a"
                })
                .ToListAsync();
        }

        public async Task<(bool result, bool nameEdit, bool imageEdit)> UpdateUser(UserProfileViewModel model, IFormFile image)
        {
            bool result = false;
            bool nameEdit = false;
            bool imageEdit = false;
            var user = await repo.GetByIdAsync<AUTH_USER>(model.Id);

            if (image != null)
            {
                string detailPath = Path.Combine(@"\img", image.FileName);
                using (var stream = new FileStream(webHostEnvironment.WebRootPath + detailPath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                if (user != null)
                {
                    if (user.USR_FULLNAME != model.FullName)
                    {
                        user.USR_FULLNAME = model.FullName;
                        nameEdit = true;
                    }

                    user.IMAGE_URL = image.FileName;
                    await repo.SaveChangesAsync();
                    result = true;
                    imageEdit = true;
                }
            }

            else if (user != null)
            {
                if (user.USR_FULLNAME != model.FullName)
                {
                    user.USR_FULLNAME = model.FullName;
                    await repo.SaveChangesAsync();
                    nameEdit = true;
                }
                result = true;
            }

            return (result, nameEdit, imageEdit);
        }
    }
}