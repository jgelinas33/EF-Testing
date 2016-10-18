using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EFTesting.Models
{
    [Table("AddressType", Schema="Person")]
    public class SalesPerson
    {
        [Key][Column("AddressTypeID")]
        public int AddressTypeId { get; set; }
        public string Name { get; set; }
        
    }
}
