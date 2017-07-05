using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Domain_Classes
{
    public class PhysicalAddress
    {
        [Key]
        public int PkPhysicalAddessId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string StreetLine1 { get; set; }


        public string StreetLine2 { get; set; }
        public string StreetLine3 { get; set; }


        public int FkUserId { get; set; }
        [ForeignKey("FkUserId")]
        public _User User { get; set; }


        public int FkSuburbId { get; set; }
        [ForeignKey("FkSuburbId")]
        public Suburb Suburb { get; set; }

    }
}
