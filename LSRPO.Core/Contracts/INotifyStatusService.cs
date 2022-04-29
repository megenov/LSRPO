using LSRPO.Core.Models.NotifyStatus;

namespace LSRPO.Core.Contracts
{
    public interface INotifyStatusService
    {
        Task<IEnumerable<ProcessDetailsViewModel>> GetProcessDetails(int id);

        Task<IEnumerable<ProcessListAllViewModel>> GetProcessAll();

        Task<ProcessListAllViewModel> GetProcess(int id);
    }
}