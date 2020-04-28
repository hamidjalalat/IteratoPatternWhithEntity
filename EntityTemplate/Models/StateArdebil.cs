using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTemplate.Models
{
    public class StateArdebil : BaseState
    {
        public StateArdebil(List<State> stateList) : base(stateList)
        {

        }
        //private List<State> _listStat;

        //public List<State> ListStat
        //{
        //    get
        //    {
        //        if (_listStat == null)
        //        {
        //            _listStat = new List<State>();

        //        }
        //        return _listStat;
        //    }
        //}

        public override bool MoveNext()
        {
            while (base.MoveNext())
            {
                State Ostate = Current as State;

                if (Ostate.Name == "Ardebil")
                {
                    //ListStat.Add(((State)Current));
                    return (true);
                }
            }

            return (false);
        }
    }
}
