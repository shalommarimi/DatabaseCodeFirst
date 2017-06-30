using DataAccessLayer.DomainClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain_Classes
{
    public class Physical_Address
    {
        [Key]
        public int PK_PhysicalAddessId { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string StreetLine3 { get; set; }


        public int FK_UserId { get; set; }
        [ForeignKey("FK_UserId")]
        public _User User { get; set; }


        public int FK_SuburbId { get; set; }
        [ForeignKey("FK_SuburbId")]
        public Suburb Suburb { get; set; }

    }
}
