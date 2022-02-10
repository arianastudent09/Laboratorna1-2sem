using System;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<decimal> decimalVi = new MyClass<decimal>();
            MyClass<double> doubleVi = new MyClass<double>();
            MyClass<short> shortVi = new MyClass<short>();
            foreach(dynamic line in new dynamic[] { decimalVi, doubleVi, shortVi})
            {
                Console.WriteLine(line.ToString());
            }
            
        }
    }
}
