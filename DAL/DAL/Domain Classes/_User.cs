using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Domain_Classes
{
    public class _User
    {
        [Key]
        public int PkUserId { get; set; }

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


        public int FkDepartmentId { get; set; }
        [ForeignKey("FkDepartmentId")]
        public virtual Department Department { get; set; }


        public int FkGenderId { get; set; }
        [ForeignKey("FkGenderId")]
        public Gender Gender { get; set; }

        public int FkUserTypeId { get; set; }
        [ForeignKey("FkUserTypeId")]
        public UserType UserType { get; set; }

        public ICollection<Physical_Address> PhysicalAddress { get; set; }
        public ICollection<Postal_Address> PostalAddress { get; set; }

    }
}
