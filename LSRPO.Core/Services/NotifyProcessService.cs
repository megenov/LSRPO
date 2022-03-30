using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyProcess;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

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

        public async Task<(bool result, string error)> EndProcess(int id)
        {
            bool result = false;
            var error = "Възникна грешка!";

            var process = await repo.GetByIdAsync<NOT_PROCESS>(id);

            if (process == null)
            {
                error = "Няма такъв процес!";
                return (result, error);
            }

            if (process.NPR_FLAG == "1" || process.NPR_FLAG == "2")
            {
                error = "Процесът вече е приключил!";
                return (result, error);
            }

            else if (process.NPR_FLAG == "0" || process.NPR_FLAG == "3")
            {
                process.NPR_FLAG = "2";

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

            return (result, error);
        }

        public async Task<IEnumerable<ProcessListViewModel>> GetProcess()
        {
            var groups = await repo.All<NOTIFY_GROUP>().ToListAsync();
            var users = await repo.All<AUTH_USER>().ToListAsync();
            var pults = await repo.All<NOT_PULT>().ToListAsync();
            var flags = await repo.All<NOT_PROCES_STATE>().ToListAsync();
            var process = await repo.All<NOT_PROCESS>().Include(i => i.NPR_TYPE).OrderByDescending(o => o.NPR_ID).Take(25).ToListAsync();

            return process.Select(s => new ProcessListViewModel
            {
                ProcessId = s.NPR_ID,
                GroupName = groups.Where(w => w.NG_ID == s.NG_ID).Select(g => g.NG_NAME).FirstOrDefault(),
                UserName = users.Where(w => w.Id == s.USR_ID).Select(u => u.USR_FULLNAME).FirstOrDefault(),
                PultName = pults.Where(w => w.PULT_NUMBER == s.PULT_NUMBER).Select(p => p.PULT_DESCR).FirstOrDefault(),
                ProccesTypeName = s.NPR_TYPE.NTP_DESCRIPTION,
                StartDate = s.NPR_DATE != null ? s.NPR_DATE.Value.ToString(FormatingConstant.CustomShowDateFormat, CultureInfo.InvariantCulture) : "n/a",
                EndDate = s.NPR_END_DATE != null ? s.NPR_END_DATE.Value.ToString(FormatingConstant.CustomShowDateFormat, CultureInfo.InvariantCulture) : "n/a",
                FlagName = flags.Where(w => w.ST_ID.ToString() == s.NPR_FLAG).Select(f => f.ST_DESC).FirstOrDefault(),
                FlagId = flags.Where(w => w.ST_ID.ToString() == s.NPR_FLAG).Select(f => f.ST_ID).FirstOrDefault(),
            }).ToList();
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