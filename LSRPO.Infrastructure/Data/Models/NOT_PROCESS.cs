using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Infrastructure.Data.Models
{
    public class NOT_PROCESS
    {
        public NOT_PROCESS()
        {
            NOT_STATUS = new HashSet<NOT_STATUS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NPR_ID { get; set; }

        public DateTime? NPR_DATE { get; set; }

        [StringLength(20)]
        public string? NPR_FLAG { get; set; }

        public int? NG_ID { get; set; }

        public int? USR_ID { get; set; }

        [ForeignKey(nameof(NPR_TYPE))]
        public int? NTP_ID { get; set; }
        public NPR_TYPE NPR_TYPE { get; set; }

        [StringLength(20)]
        public string? PULT_NUMBER { get; set; }

        public DateTime? NPR_END_DATE { get; set; }

        [StringLength(10)]
        public string? NPR_CALL_ID { get; set; }

        public bool? NPR_HORN_ID { get; set; }

        public ICollection<NOT_STATUS> NOT_STATUS { get; set; }
    }
}