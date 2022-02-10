using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class MyDict<Tkey, Tvalue>
    {
        
        public int Lich
        { get 
            { return kilk; } 
        }
        public void Add(Tkey c, Tvalue v)
        {
            kilk += 1;
            Array.Resize(ref keysArray, kilk);
            Array.Resize(ref valArray, kilk);
            keysArray[kilk - 1] = c;
            valArray[kilk - 1] = v;
        }
        public Tvalue this[Tkey c]
        {
            get
            {
                int chisl = 0;
                for(int i = 0; i < keysArray.Length; i++)
                {
                    if (c.Equals(keysArray[i])) chisl = i;
                }
                return valArray[chisl];
            }
        }
        private int kilk = 0;
        private Tkey[] keysArray = null;
        private Tvalue[] valArray = null;
    }
}
