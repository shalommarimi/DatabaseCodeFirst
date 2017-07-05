using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Domain_Classes
{
    public class City
    {
        [Key]
        public int PkCityId { get; set; }
        public string CityName { get; set; }

        public int FkProvinceId { get; set; }
        [ForeignKey("FkProvinceId")]
        public Province Province { get; set; }


    }
}
