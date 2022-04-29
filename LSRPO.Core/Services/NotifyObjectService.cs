using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyObject;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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

            if (model == null)
            {
                return (result, error);
            }

            if (repo.All<NOTIFY_OBJECT>().Any(a => a.NO_NAME == model.Name))
            {
                return (result, $"Вече съществува обект с име: {model.Name}");
            }

            var notifyObject = new NOTIFY_OBJECT { NO_NAME = model.Name, NO_INT_PHONE = model.Phone1, NP_MOB_PHONE = model.Phone2, NP_EXT_PHONE2 = model.Phone3, NP_EXT_PHONE1 = model.Phone4, NO_TYPE = model.TypeId, POSITION_ID = model.PositionId };

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

        public async Task<(bool result, string error)> AddPult(AddPultViewModel model)
        {
            bool result = false;
            string error = "Възникна грешка!";

            if (model == null)
            {
                return (result, error);
            }

            var pult = new NOT_PULT { PULT_NAME = model.Name, PULT_DESCR = model.Description, PULT_NUMBER = model.Number, PULT_IP = model.Ip };

            try
            {
                await repo.AddAsync<NOT_PULT>(pult);
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
            var notifyStatus = await repo.All<NOT_STATUS>().Where(w => w.NO_ID == id).ToListAsync();

            if (notifyObject == null)
            {
                return (result, "Няма такъв обект!");
            }

            if (notifyStatus.Count > 0)
            {
                foreach (var item in notifyStatus)
                {
                    item.NO_ID = null;
                }
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

        public async Task<(bool result, string error)> DeletePult(int id)
        {
            bool result = false;
            var error = "Възникна грешка!";

            var pult = await repo.GetByIdAsync<NOT_PULT>(id);

            if (pult == null)
            {
                return (result, "Няма такъв пулт!");
            }

            try
            {
                await repo.DeleteAsync<NOT_PULT>(id);
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
                    if (repo.All<NOTIFY_OBJECT>().Any(a => a.NO_NAME == model.Name))
                    {
                        return (result, $"Вече съществува обект с име: {model.Name}");
                    }

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

                if (notifyObject.POSITION_ID != model.PositionId)
                {
                    notifyObject.POSITION_ID = model.PositionId;
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

        public async Task<(bool result, string error)> EditPult(EditPultViewModel model)
        {
            bool result = false;
            bool changes = false;
            string error = "Възникна грешка!";

            var pult = await repo.GetByIdAsync<NOT_PULT>(model.PultId);

            if (pult != null)
            {
                if (pult.PULT_NAME != model.Name)
                {
                    pult.PULT_NAME = model.Name;
                    changes = true;
                }

                if (pult.PULT_DESCR != model.Description)
                {
                    pult.PULT_DESCR = model.Description;
                    changes = true;
                }

                if (pult.PULT_NUMBER != model.Number)
                {
                    pult.PULT_NUMBER = model.Number;
                    changes = true;
                }

                if (pult.PULT_IP != model.Ip)
                {
                    pult.PULT_IP = model.Ip;
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
                    error = "Няма направени промени по пулта!";
                }
            }

            return (result, error);
        }

        public async Task<(EditObjectViewModel notifyObject, IEnumerable<SelectListItem> types)> GetObjectForEdit(int id)
        {
            var notifyObject = await repo.GetByIdAsync<NOTIFY_OBJECT>(id);

            if (notifyObject == null)
            {
                throw new ArgumentException("Невалиден обект!");
            }

            var types = await repo.All<NO_TYPE>().Select(s => new SelectListItem() { Text = s.NO_TYPE_DESCRIPTION, Value = s.NO_TYPE_ID.ToString(), Selected = s.NO_TYPE_ID == notifyObject.NO_TYPE }).ToListAsync();

            return ( 
                new EditObjectViewModel
                {
                    ObjectId = notifyObject.NO_ID,
                    Name = notifyObject.NO_NAME,
                    Phone1 = notifyObject.NO_INT_PHONE,
                    Phone2 = notifyObject.NP_MOB_PHONE,
                    Phone3 = notifyObject.NP_EXT_PHONE2,
                    Phone4 = notifyObject.NP_EXT_PHONE1,
                    TypeId = notifyObject.NO_TYPE,
                    PositionId = notifyObject.POSITION_ID
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
                    TypeDes = nt.NO_TYPE_DESCRIPTION,
                    TypeId = nt.NO_TYPE_ID,
                    PositionId = no.NOT_POSITION.POSITION_ID,
                    PositionName = no.NOT_POSITION.POSITION_NAME
                })
                .OrderBy(o => o.PositionId != null ? o.PositionId : 999)
                .ThenBy(o => o.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<SelectListItem>> GetOperatorTypes()
        {
            return await repo.All<NO_TYPE>().Where(w => w.NO_TYPE_ID == 2).Select(s => new SelectListItem() { Text = s.NO_TYPE_DESCRIPTION, Value = s.NO_TYPE_ID.ToString() }).ToListAsync();
        }

        public async Task<IEnumerable<SelectListItem>> GetPositions()
        {
            return await repo.All<NOT_POSITION>().Select(s => new SelectListItem() { Text = s.POSITION_NAME, Value = s.POSITION_ID.ToString() }).ToListAsync();
        }

        public async Task<EditPultViewModel> GetPultForEdit(int id)
        {
            var pult = await repo.GetByIdAsync<NOT_PULT>(id);

            if (pult == null)
            {
                throw new ArgumentException("Невалиден пулт!");
            }

            return new EditPultViewModel { PultId = pult.PULT_ID, Name = pult.PULT_NAME, Description = pult.PULT_DESCR, Number = pult.PULT_NUMBER, Ip = pult.PULT_IP };
        }

        public async Task<IEnumerable<PultsViewModel>> GetPults()
        {
            return await repo.All<NOT_PULT>()
                .Select(s =>
                new PultsViewModel
                {
                    Id = s.PULT_ID,
                    Name = s.PULT_NAME,
                    Description = s.PULT_DESCR,
                    Number = s.PULT_NUMBER,
                    Ip = s.PULT_IP
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<SelectListItem>> GetTypes()
        {
            return await repo.All<NO_TYPE>().Select(s => new SelectListItem() { Text = s.NO_TYPE_DESCRIPTION, Value = s.NO_TYPE_ID.ToString() }).ToListAsync();
        }
    }
}