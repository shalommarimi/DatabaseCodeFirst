

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace Dataaccess
{
    public class Physical_Address
    {
        [Key]
        public int PK_PhysicalAddessId { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string StreetLine3 { get; set; }
        public User FK_UserId { get; set; }
        public Suburb FK_SuburbId { get; set; }

       
    }
}
