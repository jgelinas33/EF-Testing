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
         
         /// <summary>
         /// <remarks>
         /// Inverse property here points to the 'Person' property that was created in the 
         /// <see cref="PersonEmailAddress"/> entity.  It means that if you query this person object, you should get a collection of email
         /// addresses related to this person.  To make this work, the PersonEmailAddress entity 
         /// needs to have a property of the Person type with a foreign key relationship
         /// to this entity (via PersonEntityId)
         /// </remarks>
         /// </summary>
         [InverseProperty("Person")]
         public virtual ICollection<PersonEmailAddress> EmailAddresses { get; set; }


         /// <summary>
         /// <remarks>
         /// Inverse property here points to the 'Person' property that was created in the 
         /// <see cref="PersonAddressAssociation"/> entity.  It means that if you query this person object, you should get a collection of 
         /// address associations for this person.  To make this work, the PersonEmailAddress entity 
         /// needs to have a property of the Person type with a foreign key relationship
         /// to this entity (via PersonEntityId)
         /// </remarks>
         /// <remarks>
         /// The nice thing about this 'cascading' of relationships is that now, since you will get a relationship
         /// with the address associations, the PersonAddressAssociations object has a foreign key relationship directly to the 
         /// addresses table, so, in this way, when you drill down, you will get the actual addresses for this person as well.
         /// </remarks>
         /// </summary>
         [InverseProperty("Person")]
         public virtual ICollection<PersonAddressAssociation> PersonAddressAssociations { get; set; }

        
         public Person()
         {
             EmailAddresses = new List<PersonEmailAddress>();
             PersonAddressAssociations = new List<PersonAddressAssociation>();
         }

    }
}
