using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTemplate.Models
{
    public class State
    { 
        public State()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Country Country { get; set; }
        public int CountryId { get; set; }
        public virtual IList<City> Cites { get; set; }


    }
}
