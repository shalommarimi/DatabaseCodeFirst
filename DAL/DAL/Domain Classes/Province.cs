using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.DomainClasses
{
   public class Province
    {
        
        [Key]
        public int PK_ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public virtual ICollection<City> cities { get; set; }

      

    }
}
