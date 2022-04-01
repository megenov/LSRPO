using LSRPO.Core.Models.NotifyGroup;

namespace LSRPO.Core.Contracts
{
    public interface INotifyGroupService
    {
        Task<IEnumerable<NotifyGroupListViewModel>> GetGroups();

        Task<EditGroupViewModel> GetGroupForEdit(int id);

        Task<(bool result, string error)> EditGroup(EditGroupViewModel model);

        Task<string> GetGroupName(int id);

        Task<IEnumerable<EditGroupObjectsViewModel>> GetObjects(int id);

        Task<(bool result, string error)> EditGroupObjects(EditGroupObjectsViewModel model);

        Task<(bool result, string error)> ClearGroupObjects(int id);
    }
}