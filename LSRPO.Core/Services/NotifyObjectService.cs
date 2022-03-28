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

        public async Task<(bool result, string error)> AddObject(AddObjectViewModel model)
        {
            bool result = false;
            string error = "Възникна грешка!";

            var notifyObject = new NOTIFY_OBJECT { NO_NAME = model.Name, NO_INT_PHONE = model.Phone1, NP_MOB_PHONE = model.Phone2, NP_EXT_PHONE2 = model.Phone3, NP_EXT_PHONE1 = model.Phone4, NO_TYPE = model.TypeId };

            try
            {
                await repo.AddAsync<NOTIFY_OBJECT>(notifyObject);
                await repo.SaveChangesAsync();
                result = true;
            }
            catch (Exception)
            {
                error = "Неуспешен запис в Базата данни";
            }

            return (result, error);
        }

        public async Task<(bool result, string error)> DeleteObject(int id)
        {
            bool result = false;
            var error = "Възникна грешка!";

            var notifyObject = await repo.GetByIdAsync<NOTIFY_OBJECT>(id);

            if (notifyObject == null)
            {
                return (result, "Няма такъв обект!");
            }

            try
            {
                await repo.DeleteAsync<NOTIFY_OBJECT>(id);
                await repo.SaveChangesAsync();
                result = true;
            }
            catch (Exception)
            {
                error = "Неуспешен запис в Базата данни";
            }

            return (result, error);
        }

        public async Task<(bool result, string error)> EditObject(EditObjectViewModel model)
        {
            bool result = false;
            bool changes = false;
            string error = "Възникна грешка!";

            var notifyObject = await repo.GetByIdAsync<NOTIFY_OBJECT>(model.ObjectId);

            if (notifyObject != null)
            {
                if (notifyObject.NO_NAME != model.Name)
                {
                    notifyObject.NO_NAME = model.Name;
                    changes = true;
                }

                if (notifyObject.NO_INT_PHONE != model.Phone1)
                {
                    notifyObject.NO_INT_PHONE = model.Phone1;
                    changes = true;
                }

                if (notifyObject.NP_MOB_PHONE != model.Phone2)
                {
                    notifyObject.NP_MOB_PHONE = model.Phone2;
                    changes = true;
                }

                if (notifyObject.NP_EXT_PHONE2 != model.Phone3)
                {
                    notifyObject.NP_EXT_PHONE2 = model.Phone3;
                    changes = true;
                }

                if (notifyObject.NP_EXT_PHONE1 != model.Phone4)
                {
                    notifyObject.NP_EXT_PHONE1 = model.Phone4;
                    changes = true;
                }

                if (notifyObject.NO_TYPE != model.TypeId)
                {
                    notifyObject.NO_TYPE = model.TypeId;
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
                        error = "Неуспешен запис на промените в Базата данни";
                    }
                }

                else
                {
                    error = "Няма направени промени по обекта!";
                }
            }

            return (result, error);
        }

        public async Task<(EditObjectViewModel notifyObject, IEnumerable<SelectListItem> types)> GetObjectForEdit(int id)
        {
            var notifyObject = await repo.GetByIdAsync<NOTIFY_OBJECT>(id);
            var types = await repo.All<NO_TYPE>().Select(s => new SelectListItem() { Text = s.NO_TYPE_DESCRIPTION, Value = s.NO_TYPE_ID.ToString(), Selected = s.NO_TYPE_ID == notifyObject.NO_TYPE }).ToListAsync();

            return
                ( new EditObjectViewModel
                {
                    ObjectId = notifyObject.NO_ID,
                    Name = notifyObject.NO_NAME,
                    Phone1 = notifyObject.NO_INT_PHONE,
                    Phone2 = notifyObject.NP_MOB_PHONE,
                    Phone3 = notifyObject.NP_EXT_PHONE2,
                    Phone4 = notifyObject.NP_EXT_PHONE1,
                    TypeId = notifyObject.NO_TYPE
                }, types );
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

        public async Task<IEnumerable<SelectListItem>> GetTypes()
        {
            return await repo.All<NO_TYPE>().Select(s => new SelectListItem() { Text = s.NO_TYPE_DESCRIPTION, Value = s.NO_TYPE_ID.ToString() }).ToListAsync();
        }
    }
}