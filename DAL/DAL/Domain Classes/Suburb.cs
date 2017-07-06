using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Domain_Classes
{
    public class Suburb
    {
        [Key]
        public int PkSuburbId { get; set; }
        public string SuburbName { get; set; }

        public int FkCityId { get; set; }
        [ForeignKey("FkCityId")]
        public City Citys { get; set; }

        public ICollection<Postal_Address> PostalAddress { get; set; }
        public ICollection<Physical_Address> PhysicalAddress { get; set; }
        public ICollection<PostalCode> PostalCode { get; set; }
    }
}
