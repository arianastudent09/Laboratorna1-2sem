using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class MyList<T>
    {
        
        public T this[int corb]
        {
            get { return checking[corb]; } set { checking[corb] = value; }
        }
        public MyList()
        {
            this.checking = new T[1];
        }
        public MyList(int rah)
        {
            this.checking = new T[rah];
        }
        public void Add(T val)
        {
            T[] calc = new T[checking.Length + 1];
            calc[checking.Length - 1] = val;
            checking = calc;
        }
        public int Capacity { get { return checking.Length; } }
        private T[] checking = null;
    }
}
