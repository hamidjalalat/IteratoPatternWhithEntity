using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTemplate.Models
{
   public class BaseState:IEnumerable,IEnumerator
    {
        public BaseState(List<State> state)
        {
            StateArray = state;
            Reset();
        }

        public int Postion { get; set; }
        public List<State> StateArray { get; set; }
        public object Current
        {
            get
            {
                try
                {
                    return (StateArray[Postion]);
                }
                catch (System.IndexOutOfRangeException)
                {
                    throw (new System.IndexOutOfRangeException());
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (this);
        }

        public virtual bool MoveNext()
        {
            if (Postion == StateArray.Count - 1)
            {
                return (false);
            }
            else
            {
                Postion++;

                return (true);
            }
        }

        public void Reset()
        {
            Postion = -1;
        }
    }
}

