using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.Models
{
    public class TestContext:DbContext
    {
        /// <summary>
        /// <remarks>
        /// if no 'name' value used, DB Context will search config file for a connection string that
        /// matches the name of the DB Contents (TestContext).
        /// </remarks>
        /// </summary>
        public TestContext() : base("name = Adventureworks")
        {
        }
        
        //public virtual DbSet<SalesPerson> SalesPeople { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonEmailAddress> PersonEmailAddresses { get; set; }
        public virtual DbSet<PersonAddressAssociation> AddressAssociations { get; set; }
        //public virtual DbSet<AddressType>AddressTypes { get; set; }
    }
    
}
