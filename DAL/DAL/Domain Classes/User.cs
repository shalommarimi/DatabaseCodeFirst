
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL.Domain_Classes;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int FK_UserId { get; set; }
        [ForeignKey("FK_UserId")]
        public Department Department { get; set; }


        public int FK_GenderId { get; set; }
        [ForeignKey("FK_GenderId")]
        public Gender Gender { get; set; }

        public int FK_UserTypeId { get; set; }
        [ForeignKey("FK_UserTypeId")]
        public UserType UserType { get; set; }

        public List<Physical_Address> PhysicalAddress { get; set; }
        public List<Postal_Address> PostalAddress { get; set; }

    }
}
