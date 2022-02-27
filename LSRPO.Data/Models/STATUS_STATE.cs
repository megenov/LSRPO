using System.ComponentModel.DataAnnotations;

namespace LSRPO.Data.Models
{
    public class STATUS_STATE
    {
        [Key]
        public byte ST_ID { get; set; }

        [StringLength(40)]
        public string? ST_DESC { get; set; }
    }
}