using LSRPO.Core.Constants;
using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace LSRPO.Core.Services.User
{
    public class UserService : IUserService
    {
        private readonly IApplicatioDbRepository repo;

        public UserService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<(bool result, string error)> ChangePin(ChangePinViewModel model)
        {
            bool result = false;
            string error = "Възникна грешка!";
            NOT_USER_PIN? pinCode = null;
            var existPin = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.USR_PIN == model.PinCode);
            var user = await repo.All<AUTH_USER>().Where(w => w.Id == model.UserId).Include(i => i.NOT_USER_PIN).FirstOrDefaultAsync();

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

            var pinCode = await repo.GetByIdAsync<NOT_USER_PIN>(pinId);

            if (pinCode == null)
            {
                return (result, "Този потребител няма ПИН код!");
            }

            try
            {
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

        //public async Task<bool> DeleteUserPin(int id)
        //{
        //    bool result = true;
        //    var pinCode = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.USR_ID == id);

        //    if (pinCode == null)
        //    {
        //        return result;
        //    }

        //    try
        //    {
        //        //repo.Delete<NOT_USER_PIN>(pinCode);
        //        await repo.DeleteAsync<NOT_USER_PIN>(pinCode.NOT_USR_ID);
        //        await repo.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {
        //        result = false;
        //    }

        //    return result;
        //}

        public async Task<ChangePinViewModel> GetPinCode(int id)
        {
            var user = await repo.GetByIdAsync<AUTH_USER>(id);

            if (user == null)
            {
                throw new ArgumentException("Невалиден потребител!");
            }

            var pinCode = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.USR_ID == id);

            if (pinCode == null)
            {
                return new ChangePinViewModel { UserId = id, UserName = user.USR_FULLNAME };
            }

            return new ChangePinViewModel { UserId = id, PinCode = pinCode.USR_PIN, UserName = user.USR_FULLNAME };
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
                    Description = s.USR_DESC,
                    PinCode = s.NOT_USER_PIN.USR_PIN
                })
                .ToListAsync();
        }

        public async Task<(bool, UserProfileViewModel)> GetUserForProfileEdit(int id)
        {
            var model = new UserProfileViewModel();
            var user = await repo.GetByIdAsync<AUTH_USER>(id);

            if (user != null)
            {
                model = new UserProfileViewModel { Id = user.Id, UserName = user.UserName, FullName = user.USR_FULLNAME, Description = user.USR_DESC, Image = user.IMAGE_URL };
                return (true, model);
            }

            return (false, model);
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
                    Description = s.USR_DESC,
                    RegDate = s.USR_REG_DATE != null ? s.USR_REG_DATE.Value.ToString(FormatingConstant.CustomShowDateFormat, CultureInfo.InvariantCulture) : "n/a"
                })
                .ToListAsync();
        }

        public async Task<(bool result, List<string>)> HasGroup(int id)
        {
            bool result = false;

            var groups = await repo.All<NG_USR>().Where(w => w.USR_ID == id).Select(s => s.NOTIFY_GROUP.NG_DESCRIPTION).ToListAsync();

            if (groups.Count > 0)
            {
                result = true;
            }

            return (result, groups);
        }

        public async Task<bool> HasPinCode(int id)
        {
            bool result = false;

            var pinCode = await repo.All<NOT_USER_PIN>().FirstOrDefaultAsync(f => f.USR_ID == id);

            if (pinCode != null)
            {
                result = true;
            }

            return result;
        }

        public async Task<(bool result, string error)> UpdateName(UserProfileViewModel model)
        {
            bool changes = false;
            bool result = false;
            string error = string.Empty;
            var user = await repo.GetByIdAsync<AUTH_USER>(model.Id);

            if (user != null)
            {
                if (user.USR_FULLNAME != model.FullName)
                {
                    user.USR_FULLNAME = model.FullName;
                    changes = true;
                }

                if (user.USR_DESC != model.Description)
                {
                    user.USR_DESC = model.Description;
                    changes = true;
                }

                if (changes)
                {
                    try
                    {
                        await repo.SaveChangesAsync();
                        result = true;
                    }
                    catch (Exception)
                    {
                        error = "Неуспешен запис в Базата данни!";
                    }
                }
            }

            else
            {
                return (result, "Възникна грешка!");
            }

            return (result, error);
        }
    }
}