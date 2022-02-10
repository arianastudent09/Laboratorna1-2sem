using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<string, int> rik = new MyDict<string, int>();
            rik.Add("Ariana", 18);
            Console.WriteLine(rik["Ariana"]);

        }
    }
}
