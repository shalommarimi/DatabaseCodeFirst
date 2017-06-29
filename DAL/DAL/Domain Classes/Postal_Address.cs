
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class Postal_Address
    {
        [Key]
        public int PK_PostalAddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public User FK_UserId { get; set; }
        public Suburb FK_SuburbId { get; set; }
    }
}
