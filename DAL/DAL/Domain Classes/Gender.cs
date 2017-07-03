using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.DomainClasses
{
    public class Gender
    {
        [Key]
        public int PK_GenderId { get; set; }
        public string GenderValue { get; set; }
        //referencing the user table
        public ICollection<_User> user { get; set; }
    }
}
