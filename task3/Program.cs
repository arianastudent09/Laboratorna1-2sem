using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> cheker = new MyList<int>(6);
            for (int i = 0; i < cheker.Capacity; i++) {
                cheker[i] = i;
                Console.WriteLine(cheker.GetArray()[i]);
            }
        }
    }
    public static class Calculation

    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] har = new T[list.Capacity];
            for(int i = 0; i < list.Capacity; i++)
            {
                har[i] = list[i];
            }
            return har;
        }
    }
}
