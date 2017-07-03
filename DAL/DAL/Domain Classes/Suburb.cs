using DAL.Domain_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DomainClasses
{
    public class Suburb
    {
        [Key]
        public int PK_SuburbId { get; set; }
        public string SuburbName { get; set; }
        public City FK_CityId { get; set; }

        public ICollection<Postal_Address> PostalAddress {get;set;}
        public ICollection<Physical_Address> PhysicalAddress { get; set; }
        public ICollection<Postal_Code> PostalCode { get; set; }
    }
}
