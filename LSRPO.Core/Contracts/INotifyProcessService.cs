using LSRPO.Core.Models.NotifyProcess;

namespace LSRPO.Core.Contracts
{
    public interface INotifyProcessService
    {
        Task<IEnumerable<ProcessTypeListViewModel>> GetProcessTypes();

        Task<(bool result, string error)> AddProcessType(AddProcessTypeViewModel model);

        Task<EditProcessTypeViewModel> GetProcessTypeForEdit(int id);

        Task<(bool result, string error)> EditProcessType(EditProcessTypeViewModel model);
    }
}