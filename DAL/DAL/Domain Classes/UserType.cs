using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.DomainClasses
{
   public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public ICollection<_User> user { get; set; }
    }
}
