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
            
            var addresses = (from p in myTestContext.People where p.PersonEntityId == 1 select p);
        }
    }
}
