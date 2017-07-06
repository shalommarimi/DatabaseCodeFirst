using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Domain_Classes
{
    public class Gender
    {
        [Key]
        public int PkGenderId { get; set; }
        public string GenderValue { get; set; }
        public List<_User> User { get; set; }
    }
}
