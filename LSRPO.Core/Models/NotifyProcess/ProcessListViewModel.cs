namespace LSRPO.Core.Models.NotifyProcess
{
    public class ProcessListViewModel
    {
        public int ProcessId { get; set; }

        public string? GroupName { get; set; }

        public string? UserName { get; set; }

        public string? PultName { get; set; }

        public string? ProccesTypeName { get; set; }

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

        public string? FlagName { get; set; }

        public byte? FlagId { get; set; }
    }
}