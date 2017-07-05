using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.DomainClasses
{
   public class Department
    {
        [Key]
        public int PK_DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }

        public ICollection<_User> user { get; set; }
    }
}
