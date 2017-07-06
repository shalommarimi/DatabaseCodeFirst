using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Domain_Classes
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public List<_User> User { get; set; }
    }
}
