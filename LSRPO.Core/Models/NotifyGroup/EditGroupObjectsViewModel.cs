namespace LSRPO.Core.Models.NotifyGroup
{
    public class EditGroupObjectsViewModel
    {
        public int GroupId { get; set; }

        public int ObjectId { get; set; }

        public string? ObjectName { get; set; }

        public byte? ObjectType { get; set; }

        public string? Phone1 { get; set; }

        public string? Phone2 { get; set; }

        public string? Phone3 { get; set; }

        public string? Phone4 { get; set; }

        public bool IsSelected { get; set; } = false;

        public IList<int> ObjectIds { get; set; } = new List<int>();
    }
}