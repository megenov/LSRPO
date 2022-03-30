using LSRPO.Core.Models.NotifyStatus;

namespace LSRPO.Core.Contracts
{
    public interface INotifyStatusService
    {
        Task<IEnumerable<ProcessDetailsViewModel>> GetProcessDetails(int id);
    }
}