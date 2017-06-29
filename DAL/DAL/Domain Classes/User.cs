using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace DataAccessLayer.DomainClasses
{
    public class User
    {
        [Key]
        public int PK_UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDeleted { get; set; }
        //Foreign keys
        public Department FK_DepartmentId { get; set; }
        public Gender FK_GenderId { get; set; }
        public UserType FK_UserTypeId { get; set; }

    }
}
