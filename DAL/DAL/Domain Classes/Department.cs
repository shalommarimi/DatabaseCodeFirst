using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.DomainClasses
{
   public class Department
    {
        [Key]
        public int PK_DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }

        public List<_User> user { get; set; }
    }
}
