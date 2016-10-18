using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTesting.Models
{
     [Table("Person", Schema = "Person")]
    public class Person
    {
         [Key][Column("BusinessEntityID")]
         public int PersonEntityId { get; set; }
         public string Title { get; set; }
         [Required]
         public string FirstName { get; set; }         
         public string MiddleName { get; set; }
         [Required]
         public string LastName { get; set; }
         public string Suffix { get; set; }
         [ConcurrencyCheck]
         public DateTime ModifiedDate { get; set; }

         [ForeignKey("PersonEntityId")]
         public virtual List<PersonAddressAssociation> AddressAssociations { get; set; }

         [ForeignKey("PersonEntityId")]
         public virtual List<PersonEmailAddress> EmailAddresses { get; set; }

    }
}
