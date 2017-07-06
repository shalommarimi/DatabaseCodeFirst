using System.ComponentModel.DataAnnotations;

namespace DAL.Domain_Classes
{
    public class PostalCode
    {
        [Key]
        public int PkPostalCodeId { get; set; }
        public string PostalCodeNumber { get; set; }
        public Suburb FkSuburbId { get; set; }

    }
}
