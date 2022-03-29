using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyProcess;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LSRPO.Core.Services
{
    public class NotifyProcessService : INotifyProcessService
    {
        private readonly IApplicatioDbRepository repo;

        public NotifyProcessService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<(bool result, string error)> AddProcessType(AddProcessTypeViewModel model)
        {
            bool result = false;
            string error = "Възникна грешка!";

            var processType = new NPR_TYPE { NTP_DESCRIPTION = model.Description };

            try
            {
                await repo.AddAsync<NPR_TYPE>(processType);
                await repo.SaveChangesAsync();
                result = true;
            }
            catch (Exception)
            {
                error = "Неуспешен запис в Базата данни";
            }

            return (result, error);
        }

        public async Task<(bool result, string error)> EditProcessType(EditProcessTypeViewModel model)
        {
            bool result = false;
            string error = "Възникна грешка!";

            var processType = await repo.GetByIdAsync<NPR_TYPE>(model.ProcessTypeId);

            if (processType != null)
            {
                if (processType.NTP_DESCRIPTION != model.Description)
                {
                    processType.NTP_DESCRIPTION = model.Description;

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
                    error = "Няма направени промени по този тип процес!";
                }
            }

            return (result, error);
        }

        public async Task<EditProcessTypeViewModel> GetProcessTypeForEdit(int id)
        {
            var processType = await repo.GetByIdAsync<NPR_TYPE>(id);

            return new EditProcessTypeViewModel { ProcessTypeId = processType.NTP_ID, Description = processType.NTP_DESCRIPTION };
        }

        public async Task<IEnumerable<ProcessTypeListViewModel>> GetProcessTypes()
        {
            return await repo.All<NPR_TYPE>()
                .Select(s =>
                new ProcessTypeListViewModel
                {
                    Id = s.NTP_ID,
                    Description = s.NTP_DESCRIPTION
                })
                .ToListAsync();
        }
    }
}