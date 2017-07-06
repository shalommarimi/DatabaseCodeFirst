using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Domain_Classes
{
    public class Province
    {

        [Key]
        public int PkProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public virtual ICollection<City> Cities { get; set; }



    }
}
