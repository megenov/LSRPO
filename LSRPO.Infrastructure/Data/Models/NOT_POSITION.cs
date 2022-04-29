using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Infrastructure.Data.Models
{
    public class NOT_POSITION
    {
        public NOT_POSITION()
        {
            NOTIFY_OBJECTS = new HashSet<NOTIFY_OBJECT>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int POSITION_ID { get; set; }

        [StringLength(10)]
        public string POSITION_NAME { get; set; }

        [StringLength(100)]
        public string? POSITION_DESCR { get; set; }

        public ICollection<NOTIFY_OBJECT> NOTIFY_OBJECTS { get; set; }
    }
}