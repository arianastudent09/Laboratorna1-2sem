using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> checker = new MyList<int>();
            int lich = 0;
            foreach(int val in new int[3] { 2, 4, 6 })
            {
                checker.Add(val);
                Console.WriteLine(checker[lich]);
                lich++;
            }
        }
    }
}
