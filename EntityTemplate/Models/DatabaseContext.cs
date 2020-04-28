using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTemplate.Models
{
    public class DatabaseContext:DbContext
    {
        static DatabaseContext()
        {
            System.Data.Entity.Database
                .SetInitializer(new DatabaseContextInitializer());
        }
        public DatabaseContext()
        {

        }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cites { get; set; }



    }
}
