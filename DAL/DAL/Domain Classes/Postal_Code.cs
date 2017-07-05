using System.ComponentModel.DataAnnotations;


namespace DataAccessLayer.DomainClasses
{
    public class Postal_Code
    {
        [Key]
        public int PK_PostalCodeId { get; set; }
        public string PostalCodeNumber { get; set; }
        public Suburb FK_SuburbId { get; set; }

    }
}
