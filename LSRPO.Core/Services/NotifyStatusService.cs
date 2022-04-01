using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyStatus;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace LSRPO.Core.Services
{
    public class NotifyStatusService : INotifyStatusService
    {
        private readonly IApplicatioDbRepository repo;

        public NotifyStatusService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<ProcessListAllViewModel>> GetProcessAll()
        {
            var groups = await repo.All<NOTIFY_GROUP>().ToListAsync();
            var users = await repo.All<AUTH_USER>().ToListAsync();
            var pults = await repo.All<NOT_PULT>().ToListAsync();
            var flags = await repo.All<NOT_PROCES_STATE>().ToListAsync();
            var process = await repo.All<NOT_PROCESS>().Include(i => i.NPR_TYPE).ToListAsync();

            return process.Select(s => new ProcessListAllViewModel
            {
                ProcessId = s.NPR_ID,
                GroupName = groups.Where(w => w.NG_ID == s.NG_ID).Select(g => g.NG_NAME).FirstOrDefault(),
                UserName = users.Where(w => w.Id == s.USR_ID).Select(u => u.USR_FULLNAME).FirstOrDefault(),
                PultName = pults.Where(w => w.PULT_NUMBER == s.PULT_NUMBER).Select(p => p.PULT_DESCR).FirstOrDefault(),
                ProccesTypeName = s.NPR_TYPE != null ? s.NPR_TYPE.NTP_DESCRIPTION : "N/A",
                StartDate = s.NPR_DATE != null ? s.NPR_DATE.Value.ToString(FormatingConstant.CustomShowDateFormat, CultureInfo.InvariantCulture) : "N/A",
                EndDate = s.NPR_END_DATE != null ? s.NPR_END_DATE.Value.ToString(FormatingConstant.CustomShowDateFormat, CultureInfo.InvariantCulture) : "N/A",
                FlagName = flags.Where(w => w.ST_ID.ToString() == s.NPR_FLAG).Select(f => f.ST_DESC).FirstOrDefault(),
                FlagId = flags.Where(w => w.ST_ID.ToString() == s.NPR_FLAG).Select(f => f.ST_ID).FirstOrDefault(),
            })
                .OrderByDescending(o => o.ProcessId)
                .ToList();
        }

        public async Task<IEnumerable<ProcessDetailsViewModel>> GetProcessDetails(int id)
        {
            var phoneStates = await repo.All<NOT_STATUS_PHONE_STATE>().ToListAsync();
            var finalStates = await repo.All<NOT_STATUS_STATE>().ToListAsync();
            var statusStates = await repo.All<STATUS_STATE>().ToListAsync();
            var status = await repo.All<NOT_STATUS>().Include(i => i.NOTIFY_OBJECT).Where(w => w.NPR_ID == id).ToListAsync();

            return status.Select(s => new ProcessDetailsViewModel
            {
                StatId = s.STAT_ID,
                StatFlag = statusStates.Where(w => w.ST_ID == s.STAT_FLAG).Select(f => f.ST_DESC).FirstOrDefault(),
                ObjectName = s.NOTIFY_OBJECT != null ? s.NOTIFY_OBJECT.NO_NAME : "Изтрит обект",
                Phone1 = s.STAT_INT_PHONE,
                Phone1Flag = phoneStates.Where(w => w.ST_ID == s.STAT_INT_FLAG).Select(f => f.ST_DESC).FirstOrDefault(),
                Phone2 = s.STAT_MOB_PHONE,
                Phone2Flag = phoneStates.Where(w => w.ST_ID == s.STAT_MOB_FLAG).Select(f => f.ST_DESC).FirstOrDefault(),
                Phone3 = s.STAT_PHONE2,
                Phone3Flag = phoneStates.Where(w => w.ST_ID == s.STAT_PH2_FLAG).Select(f => f.ST_DESC).FirstOrDefault(),
                Phone4 = s.STAT_PHONE1,
                Phone4Flag = phoneStates.Where(w => w.ST_ID == s.STAT_PH1_FLAG).Select(f => f.ST_DESC).FirstOrDefault(),
                FinalFlag = finalStates.Where(w => w.ST_ID == s.STAT_NOTIFICATION).Select(f => f.ST_DESC).FirstOrDefault()
            }).ToList();
        }
    }
}