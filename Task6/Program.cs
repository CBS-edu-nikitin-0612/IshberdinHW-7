using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 5, c = -1;
            Calculate(a, b, c);
            Console.ReadLine();
        }
        static void Calculate(int a, int b, int c) { Console.WriteLine((a + b + c) / 3.0); }
    }
}
