using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTesting.Models
{
    [Table("Address",Schema = "Person")]
    public class Address
    {
        [Key][Column("AddressID")]
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        [Column("StateProvinceID")]
        public int StateProvinceId { get; set; }
        public string PostalCode { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
