using LSRPO.Core.Models.NotifyObject;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LSRPO.Core.Contracts
{
    public interface INotifyObjectService
    {
        Task<IEnumerable<NotifyObjectListViewModel>> GetObjects();

        Task<IEnumerable<SelectListItem>> GetTypes();

        Task<(bool result, string error)> AddObject(AddObjectViewModel model);

        Task<(EditObjectViewModel notifyObject, IEnumerable<SelectListItem> types)> GetObjectForEdit(int id);

        Task<(bool result, string error)> EditObject(EditObjectViewModel model);

        Task<(bool result, string error)> DeleteObject(int id);

        Task<IEnumerable<PultsViewModel>> GetPults();

        Task<(bool result, string error)> AddPult(AddPultViewModel model);

        Task<(bool result, string error)> DeletePult(int id);
    }
}