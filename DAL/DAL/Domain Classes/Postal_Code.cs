
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class Postal_Code
    {
        [Key]
        public int PK_PostalCodeId { get; set; }
        public string PostalCodeNumber { get; set; }
        public Suburb FK_SuburbId { get; set; }

    }
}
