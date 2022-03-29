using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyGroup;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
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

        public async Task<EditGroupViewModel> GetGroupForEdit(int id)
        {
            var notifyGroup = await repo.GetByIdAsync<NOTIFY_GROUP>(id);

            return new EditGroupViewModel { GroupId = notifyGroup.NG_ID, Name = notifyGroup.NG_NAME, Description = notifyGroup.NG_DESCRIPTION, Number = notifyGroup.NG_NUMBER };
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
    }
}