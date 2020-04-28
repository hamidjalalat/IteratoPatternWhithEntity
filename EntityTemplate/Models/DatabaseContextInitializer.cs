using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTemplate.Models
{
    public class DatabaseContextInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        public DatabaseContextInitializer()
        {

        }
        protected override void Seed(DatabaseContext context)
        {
            for (int i = 0; i < 5; i++)
            {
                Country oCountry = new Country();
                oCountry.Name = "Country" +
                    i.ToString();
                oCountry.States = new List<State>();
                for (int j = 0; j < 200; j++)
                {
                    State oState = new State();
                    oState.Name = "City" +
                       j.ToString();
                    oCountry.States.Add(oState);
                }
                context.Countrys.Add(oCountry);

            }


            context.SaveChanges();
        }

    }
}
