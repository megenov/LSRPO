using LSRPO.Core.Models.NotifyObject;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LSRPO.Core.Contracts
{
    public interface INotifyObjectService
    {
        Task<IEnumerable<NotifyObjectListViewModel>> GetObjects();

        List<SelectListItem> GetTypes();
    }
}