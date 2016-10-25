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
    [Table("EmailAddress",Schema="Person")]
    public class PersonEmailAddress
    {
        [Key, Column("BusinessEntityID",Order=1)]
        public int PersonEntityId { get; set; }
        [Key,Column("EmailAddressID", Order=2)]
        public int EmailAddressId { get; set; }
        public string EmailAddress { get; set; }
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("PersonEntityId")]
        public virtual Person Person { get; set; }
    }
}
