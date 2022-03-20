namespace LSRPO.Core.Models.User
{
    public class UserRolesViewModel
    {
        public int UserId { get; set; }

        public string FullName { get; set; }

        public int[] RoleIds { get; set; }
    }
}