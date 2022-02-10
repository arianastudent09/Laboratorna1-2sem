using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    public class MyList<T>
    {
        
        public T this[int calc]
        {
            get { return nechek[calc]; } 
            
            set { nechek[calc] = value; }
        }
        public MyList()
        {
            this.nechek = new T[1];
        }
        public MyList(int ral)
        {
            this.nechek = new T[ral];
        }
        public void Add(T val)
        {
            T[] har = new T [nechek.Length + 1];
            har[nechek.Length - 1] = val;
            nechek = har;
        }
        public int Capacity { get { return nechek.Length; } }
        private T[] nechek = null;
    }
}
