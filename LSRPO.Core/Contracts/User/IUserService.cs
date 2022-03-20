using LSRPO.Core.Models.User;

namespace LSRPO.Core.Contracts.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserListViewModel>> GetUsers();

        Task<UserEditViewModel> GetUserForEdit(int id);

        Task<bool> UpdateUser(UserEditViewModel model);

        //Task<bool> UpdateRoles(UserRolesViewModel model);
    }
}