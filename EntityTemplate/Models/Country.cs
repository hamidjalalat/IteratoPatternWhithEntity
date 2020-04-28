using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTemplate.Models
{
   public  class Country
    {
        public Country()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<State> States { get; set; }

    }
}
