using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTesting.Models
{
    /// <summary>
    /// <remarks>
    /// The EmailAddress table has more than one field
    /// that acts for a key.  The Column keyword in the annotation
    /// indicates the order in which those keys should be applied by 
    /// </remarks>
    /// </summary>
    [Table("AddressType", Schema = "Person")]
    public class AddressType
    {
        [Key][Column("AddressTypeID")]
        public int AddressTypeId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
