using LSRPO.Core.Models.User;

namespace LSRPO.Core.Contracts.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserListViewModel>> GetUsers();
    }
}