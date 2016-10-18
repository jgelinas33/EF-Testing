using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.Models
{
    internal sealed class Configuration:DbMigrationsConfiguration<EFTesting.Models.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EFTesting.Models.TextContext";
        }
    }
}
