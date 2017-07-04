using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int FK_ProvinceId { get; set; }
        [ForeignKey("FK_ProvinceId")]
        public Province Province { get; set; }

        
    }
}
