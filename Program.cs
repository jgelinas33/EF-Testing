using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTesting.Models;

namespace EFTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTestContext = new TestContext();
            
           // var addresses = (from p in myTestContext.People where p.PersonEntityId == 1 select p);
           // var emailAddresses = myTestContext.PersonEmailAddresses.ToList();

            var personAddressAssociations =
                (from a in myTestContext.AddressAssociations where a.AddressType.Name == "Home" select a ) ;

            //var person = (from p in myTestContext.People where p.PersonEntityId == 1 select p);
        }
    }
}
