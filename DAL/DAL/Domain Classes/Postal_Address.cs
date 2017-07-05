using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccessLayer.DomainClasses
{
    public class Postal_Address
    {
        [Key]
        public int PK_PostalAddressId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        public int FK_UserId { get; set; }
        [ForeignKey("FK_UserId")]
        public _User User { get; set; }


        public int FK_SuburbId { get; set; }
        [ForeignKey("FK_SuburbId")]
        public Suburb Suburb { get; set; }
    }
}
