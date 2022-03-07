using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Infrastructure.Data.Models
{
    public class NOT_PULT
    {
        public NOT_PULT()
        {
            NOTIFY_OBJECTS = new HashSet<NOTIFY_OBJECT>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PULT_ID { get; set; }

        [StringLength(100)]
        public string? PULT_NAME { get; set; }

        [StringLength(100)]
        public string? PULT_DESCR { get; set; }

        [StringLength(20)]
        public string? PULT_IP { get; set; }

        [StringLength(20)]
        public string? PULT_NUMBER { get; set; }

        public ICollection<NOTIFY_OBJECT> NOTIFY_OBJECTS { get; set; }
    }
}