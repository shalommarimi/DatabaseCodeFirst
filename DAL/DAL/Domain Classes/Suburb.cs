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

        public List<Postal_Address> PostalAddress { get; set; }
        public List<Physical_Address> PhysicalAddress { get; set; }
        public List<PostalCode> PostalCode { get; set; }
    }
}
