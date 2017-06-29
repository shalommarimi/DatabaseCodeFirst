using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvinceCity
{
   public class Province
    {
        
        [Key]
        public int PK_ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public virtual List<City> cities { get; set; }

      

    }
}
