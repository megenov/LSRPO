using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using LSRPO.Infrastructure.Data;

namespace LSRPO.Core.Services.User
{
    public class UserService : IUserService
    {
        private readonly IApplicatioDbRepository repo;
        private readonly IWebHostEnvironment webHostEnvironment;

        private readonly ApplicationDbContext dbContext;

        public UserService(IApplicatioDbRepository repo, IWebHostEnvironment webHostEnvironment, ApplicationDbContext dbContext)
        {
            this.repo = repo;
            this.webHostEnvironment = webHostEnvironment;
            this.dbContext = dbContext;
        }

        public async Task<(bool result, string error)> DeletePinCode(int pinId)
        {
            bool result = false;
            var error = string.Empty;

            var pinCode = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.NOT_USR_ID == pinId);
            var pinCode2 = await dbContext.NOT_USERS_PIN.FirstOrDefaultAsync(f => f.NOT_USR_ID == pinId);

            if (pinCode2 == null)
            {
                return (result, "Този потребител няма ПИН код!");
            }

            try
            {
                //await repo.DeleteAsync<NOT_USER_PIN>(pinCode);
                //await repo.SaveChangesAsync();

                dbContext.Remove(pinCode2);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                error = "Неуспешен запис на промените в Базата данни";
            }

           return (result, error);
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
            return await repo.All<AUTH_USER>().Select(s => new UserListViewModel { Id = s.Id, UserName = s.UserName, FullName = s.USR_FULLNAME }).ToListAsync();
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