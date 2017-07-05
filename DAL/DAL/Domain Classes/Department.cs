using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Domain_Classes
{
    public class Department
    {
        [Key]
        public int PkDepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }

        public ICollection<_User> User { get; set; }
    }
}
