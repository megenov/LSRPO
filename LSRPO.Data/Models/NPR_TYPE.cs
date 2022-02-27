using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Data.Models
{
    public class NPR_TYPE
    {
        public NPR_TYPE()
        {
            NOT_PROCESS = new HashSet<NOT_PROCESS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NTP_ID { get; set; }

        [StringLength(100)]
        public string? NTP_DESCRIPTION { get; set; }

        public ICollection<NOT_PROCESS> NOT_PROCESS { get; set; }
    }
}