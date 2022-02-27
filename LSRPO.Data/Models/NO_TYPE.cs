using System.ComponentModel.DataAnnotations;

namespace LSRPO.Data.Models
{
    public class NO_TYPE
    {
        [Key]
        public byte NO_TYPE_ID { get; set; }

        [StringLength(40)]
        public string? NO_TYPE_DESCRIPTION { get; set; }
    }
}