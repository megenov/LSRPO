using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyGroup;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace LSRPO.Core.Services
{
    public class NotifyGroupService : INotifyGroupService
    {
        private readonly IApplicatioDbRepository repo;

        public NotifyGroupService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<(bool result, string error)> ClearGroupObjects(int id)
        {
            bool result = false;
            string error = "Възникна грешка!";

            var notifyGroup = await repo.GetByIdAsync<NOTIFY_GROUP>(id);
            var ngnps = await repo.All<NG_NP>().Where(w => w.NG_ID == id).ToListAsync();

            if (notifyGroup != null)
            {
                if (ngnps.Count > 0)
                {
                    try
                    {
                        repo.DeleteRange<NG_NP>(ngnps);
                        await repo.SaveChangesAsync();
                        result = true;
                    }
                    catch (Exception)
                    {
                        error = "Неуспешен запис на промените в Базата данни!";
                    }
                }

                else
                {
                    error = $"Няма обекти в {notifyGroup.NG_DESCRIPTION}!";
                }
            }

            return (result, error);
        }

        public async Task<(bool result, string error)> ClearGroupUsers(int id)
        {
            bool result = false;
            string error = "Възникна грешка!";

            var notifyGroup = await repo.GetByIdAsync<NOTIFY_GROUP>(id);
            var ngusrs = await repo.All<NG_USR>().Where(w => w.NG_ID == id).ToListAsync();

            if (notifyGroup != null)
            {
                if (ngusrs.Count > 0)
                {
                    try
                    {
                        repo.DeleteRange<NG_USR>(ngusrs);
                        await repo.SaveChangesAsync();
                        result = true;
                    }
                    catch (Exception)
                    {
                        error = "Неуспешен запис на промените в Базата данни!";
                    }
                }

                else
                {
                    error = $"Няма потребители в {notifyGroup.NG_DESCRIPTION}!";
                }
            }

            return (result, error);
        }

        public async Task<(bool result, string error)> EditGroup(EditGroupViewModel model)
        {
            bool result = false;
            bool changes = false;
            string error = "Възникна грешка!";

            var notifyGroup = await repo.GetByIdAsync<NOTIFY_GROUP>(model.GroupId);

            if (notifyGroup != null)
            {
                if (notifyGroup.NG_NAME != model.Name)
                {
                    notifyGroup.NG_NAME = model.Name;
                    changes = true;
                }

                if (notifyGroup.NG_DESCRIPTION != model.Description)
                {
                    notifyGroup.NG_DESCRIPTION = model.Description;
                    changes = true;
                }

                if (notifyGroup.NG_NUMBER != model.Number)
                {
                    notifyGroup.NG_NUMBER = model.Number;
                    changes = true;
                }

                if (notifyGroup.NG_MOD_FLAG != model.Flag)
                {
                    notifyGroup.NG_MOD_FLAG = model.Flag;
                    changes = true;
                }

                if (changes)
                {
                    notifyGroup.NG_REG_DATE = DateTime.Now;

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

                else
                {
                    error = "Няма направени промени по групата!";
                }
            }

            return (result, error);
        }

        public async Task<(bool result, string error)> EditGroupObjects(EditGroupObjectsViewModel model)
        {
            bool result = false;
            bool changes = false;
            string error = "Възникна грешка!";

            var notifyGroup = await repo.GetByIdAsync<NOTIFY_GROUP>(model.GroupId);
            var ngnps = await repo.All<NG_NP>().Where(w => w.NG_ID == model.GroupId).ToListAsync();

            if (notifyGroup != null)
            {
                if (ngnps.Count > 0)
                {
                    var isEqual = ngnps.All(a => model.ObjectIds.Contains(a.NO_ID)) && ngnps.Count == model.ObjectIds.Count;

                    if (isEqual)
                    {
                        return (result, $"Обектите в {notifyGroup.NG_DESCRIPTION} са същите като предишните!");
                    }

                    try
                    {
                        repo.DeleteRange<NG_NP>(ngnps);
                    }
                    catch (Exception)
                    {
                        return (result, error);
                    }

                    changes = true;
                }

                if (model.ObjectIds.Count > 0)
                {
                    var notifyGroupObjects = new List<NG_NP>();

                    foreach (var id in model.ObjectIds)
                    {
                        //var notifyObject = await repo.GetByIdAsync<NOTIFY_OBJECT>(id);
                        //var ngnp = new NG_NP { NOTIFY_GROUP = notifyGroup, NOTIFY_OBJECT = notifyObject };

                        var ngnp = new NG_NP { NOTIFY_GROUP = notifyGroup, NO_ID = id };
                        notifyGroupObjects.Add(ngnp);
                    }

                    try
                    {
                        await repo.AddRangeAsync<NG_NP>(notifyGroupObjects);
                    }
                    catch (Exception)
                    {
                        return (result, error);
                    }

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
                        error = "Неуспешен запис в Базата данни";
                    }
                }

                else
                {
                    error = $"Няма редактирани обекти в {notifyGroup.NG_DESCRIPTION}!";
                }
            }

            return (result, error);
        }

        public async Task<(bool result, string error)> EditGroupUsers(EditGroupUsersViewModel model)
        {
            bool result = false;
            bool changes = false;
            string error = "Възникна грешка!";

            var notifyGroup = await repo.GetByIdAsync<NOTIFY_GROUP>(model.GroupId);
            var ngusrs = await repo.All<NG_USR>().Where(w => w.NG_ID == model.GroupId).ToListAsync();

            if (notifyGroup != null)
            {
                if (ngusrs.Count > 0)
                {
                    var isEqual = ngusrs.All(a => model.UserIds.Contains(a.USR_ID != null ? (int)a.USR_ID : 0 )) && ngusrs.Count == model.UserIds.Count;

                    if (isEqual)
                    {
                        return (result, $"Потребителите в {notifyGroup.NG_DESCRIPTION} са същите като предишните!");
                    }

                    try
                    {
                        repo.DeleteRange<NG_USR>(ngusrs);
                    }
                    catch (Exception)
                    {
                        return (result, error);
                    }

                    changes = true;
                }

                if (model.UserIds.Count > 0)
                {
                    var notifyGroupUsers = new List<NG_USR>();

                    foreach (var id in model.UserIds)
                    {
                        var ngusr = new NG_USR { NOTIFY_GROUP = notifyGroup, USR_ID = id };
                        notifyGroupUsers.Add(ngusr);
                    }

                    try
                    {
                        await repo.AddRangeAsync<NG_USR>(notifyGroupUsers);
                    }
                    catch (Exception)
                    {
                        return (result, error);
                    }

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
                        error = "Неуспешен запис в Базата данни";
                    }
                }

                else
                {
                    error = $"Няма редактирани потребители в {notifyGroup.NG_DESCRIPTION}!";
                }
            }

            return (result, error);
        }

        public async Task<bool?> GetGroupFlag(int id)
        {
            var groupFlag = await repo.All<NOTIFY_GROUP>().Where(w => w.NG_ID == id).Select(s => s.NG_MOD_FLAG).FirstOrDefaultAsync();

            return groupFlag;
        }

        public async Task<EditGroupViewModel> GetGroupForEdit(int id)
        {
            var notifyGroup = await repo.GetByIdAsync<NOTIFY_GROUP>(id);

            if (notifyGroup == null)
            {
                throw new ArgumentException("Невалидна група!");
            }

            return new EditGroupViewModel
            {
                GroupId = notifyGroup.NG_ID,
                Name = notifyGroup.NG_NAME,
                Description = notifyGroup.NG_DESCRIPTION,
                Number = notifyGroup.NG_NUMBER,
                Flag = notifyGroup.NG_MOD_FLAG != null ? (bool)notifyGroup.NG_MOD_FLAG : false
            };
        }

        public async Task<string?> GetGroupName(int id)
        {
            var group = await repo.GetByIdAsync<NOTIFY_GROUP>(id);

            if (group == null)
            {
                throw new ArgumentException($"Няма група с Id {id}!");
            }

            return group.NG_DESCRIPTION;
        }

        public async Task<IEnumerable<NotifyGroupListViewModel>> GetGroups()
        {
            return await repo.All<NOTIFY_GROUP>()
                .Select(s =>
                new NotifyGroupListViewModel
                {
                    Id = s.NG_ID,
                    Name = s.NG_NAME,
                    Description = s.NG_DESCRIPTION,
                    Number = s.NG_NUMBER,
                    DateOfChange = s.NG_REG_DATE != null ? s.NG_REG_DATE.Value.ToString(FormatingConstant.CustomShowDateFormat, CultureInfo.InvariantCulture) : "n/a",
                    Flag = s.NG_MOD_FLAG
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<EditGroupObjectsViewModel>> GetObjects(int id)
        {
            return await repo.All<NOTIFY_OBJECT>()
                .Select(s =>
                new EditGroupObjectsViewModel
                {
                    GroupId = id,
                    ObjectId = s.NO_ID,
                    ObjectName = s.NO_NAME,
                    ObjectType = s.NO_TYPE,
                    Phone1 = s.NO_INT_PHONE,
                    Phone2 = s.NP_MOB_PHONE,
                    Phone3 = s.NP_EXT_PHONE2,
                    Phone4 = s.NP_EXT_PHONE1,
                    IsSelected = s.NG_NPS.Where(w => w.NG_ID == id).Any(a => a.NO_ID == s.NO_ID)
                })
                .OrderBy(o => o.ObjectName)
                .ToListAsync();
        }

        public async Task<IEnumerable<EditGroupUsersViewModel>> GetUsers(int id)
        {
            return await repo.All<AUTH_USER>()
                .Select(s =>
                new EditGroupUsersViewModel
                {
                    GroupId = id,
                    UserId = s.Id,
                    UserName = s.UserName,
                    FullName = s.USR_FULLNAME,
                    UserDescription = s.USR_DESC,
                    IsSelected = s.NG_USRS.Where(w => w.NG_ID == id).Any(a => a.USR_ID == s.Id)
                })
                .OrderBy(o => o.FullName)
                .ToListAsync();
        }
    }
}