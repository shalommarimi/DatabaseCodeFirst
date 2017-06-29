using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class Suburb
    {
        [Key]
        public int PK_SuburbId { get; set; }
        public string SuburbName { get; set; }
        public City FK_CityId { get; set; }

        public List<Postal_Address> PostalAddress {get;set;}
        public List<Physical_Address> PhysicalAddress { get; set; }
        public List<Postal_Code> PostalCode { get; set; }
    }
}
