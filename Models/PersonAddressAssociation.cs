using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace EFTesting.Models
{
    /// <summary>
    /// <remarks>
    /// The EmailAddress table has more than one field
    /// that acts for a key.  The Column keyword in the annotation
    /// indicates the order in which those keys should be applied by 
    /// </remarks>
    /// </summary>
    [Table("BusinessEntityAddress",Schema = "Person")]
    public class PersonAddressAssociation
    {
        [Key, Column("BusinessEntityID",Order = 1) ]
        public int PersonEntityId { get; set; }
        [Key, Column("AddressID",Order = 2)]
        public int AddressId { get; set; }
        [Key, Column("AddressTypeID", Order = 3)]
        public int AddressTypeId { get; set; }
        public DateTime ModifiedDate { get; set; }


        [ForeignKey("AddressId")]
        public virtual Address PersonAddress { get; set; }

        [ForeignKey("PersonEntityId")]
        public virtual Person Person { get; set; }

        [ForeignKey("AddressTypeId")]
        public virtual AddressType AddressType { get; set; }

        
    }
}
