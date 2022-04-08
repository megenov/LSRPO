using LSRPO.Core.Models.User;

namespace LSRPO.Core.Contracts.User
{
    public interface IUserService
    {
        Task<IEnumerable<UserListViewModel>> GetUsers();

        Task<UserProfileViewModel> GetUserForProfileEdit(int id);

        Task<(bool result, string error)> UpdateName(UserProfileViewModel model);

        Task<IEnumerable<PinCodesViewModel>> GetPinCodes();

        Task<ChangePinViewModel> GetPinCode(int id);

        Task<(bool result, string error)> ChangePin(ChangePinViewModel model);

        Task<(bool result, string error)> DeletePinCode(int pinId);

        //Task<bool> DeleteUserPin(int id);

        Task<bool> HasPinCode(int id);

        Task<(bool result, List<string>)> HasGroup(int id);
    }
}