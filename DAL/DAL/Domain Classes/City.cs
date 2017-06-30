using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DomainClasses
{
    public class City
    {
        [Key]
        public int PK_CityId { get; set; }
        public string CityName { get; set; }
        public Province Provinces { get; set; }

        
    }
}
