using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyObject;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSRPO.Core.Services
{
    public class NotifyObjectService : INotifyObjectService
    {
        private readonly IApplicatioDbRepository repo;

        public NotifyObjectService(IApplicatioDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<NotifyObjectListViewModel>> GetObjects()
        {
            return await repo.All<NOTIFY_OBJECT>()
                .SelectMany(sm => repo.All<NO_TYPE>().Where(w => w.NO_TYPE_ID == sm.NO_TYPE).DefaultIfEmpty(),
                (no, nt) => new NotifyObjectListViewModel
                {
                    Id = no.NO_ID,
                    Name = no.NO_NAME,
                    Phone1 = no.NO_INT_PHONE,
                    Phone2 = no.NP_MOB_PHONE,
                    Phone3 = no.NP_EXT_PHONE2,
                    Phone4 = no.NP_EXT_PHONE1,
                    TypeDes = nt.NO_TYPE_DESCRIPTION
                })
                .ToListAsync();
        }

        public List<SelectListItem> GetTypes()
        {
            return repo.All<NO_TYPE>()
                .ToList()
                .Select(s => new SelectListItem() { Text = s.NO_TYPE_DESCRIPTION, Value = s.NO_TYPE_ID.ToString(), Selected = false })
                .ToList();
        }
    }
}