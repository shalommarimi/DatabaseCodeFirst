using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL.Domain_Classes;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.DomainClasses
{
    public class _User
    {
        [Key]
        public int PK_UserId { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]// No numerics are allowed
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(300)]
        public string Password { get; set; }

        public bool IsApproved { get; set; }
        public bool IsDeleted { get; set; }


        public int FK_DepartmentId { get; set; }
        [ForeignKey("FK_DepartmentId")]
        public virtual Department Department { get; set; }


        public int FK_GenderId { get; set; }
        [ForeignKey("FK_GenderId")]
        public Gender Gender { get; set; }

        public int FK_UserTypeId { get; set; }
        [ForeignKey("FK_UserTypeId")]
        public UserType UserType { get; set; }

        public ICollection<Physical_Address> PhysicalAddress { get; set; }
        public ICollection<Postal_Address> PostalAddress { get; set; }

    }
}
