using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Data.Models
{
    public class NOTIFY_OBJECT
    {
        public NOTIFY_OBJECT()
        {
            NOT_STATUS = new HashSet<NOT_STATUS>();
            NG_NPS = new HashSet<NG_NP>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NO_ID { get; set; }

        [StringLength(200)]
        public string? NO_NAME { get; set; }

        [StringLength(20)]
        public string? NO_INT_PHONE { get; set; }

        [StringLength(20)]
        public string? NP_MOB_PHONE { get; set; }

        [StringLength(20)]
        public string? NP_EXT_PHONE1 { get; set; }

        [StringLength(20)]
        public string? NP_EXT_PHONE2 { get; set; }

        public byte? NO_TYPE { get; set; }

        [ForeignKey(nameof(NOT_PULT))]
        public int? PULT_ID { get; set; }
        public NOT_PULT NOT_PULT { get; set; }

        public ICollection<NOT_STATUS> NOT_STATUS { get; set; }

        public ICollection<NG_NP> NG_NPS { get; set; }
    }
}