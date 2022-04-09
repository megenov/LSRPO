namespace LSRPO.Core.Models.NotifyGroup
{
    public class EditGroupUsersViewModel
    {
        public int GroupId { get; set; }

        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? FullName { get; set; }

        public string? UserDescription { get; set; }

        public bool IsSelected { get; set; } = false;

        public IList<int> UserIds { get; set; } = new List<int>();
    }
}