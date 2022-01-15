using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = -7;
            Console.WriteLine($"Число {num}\n" +
                $"положительное: {IsPositive(num)}\n" +
                $"простое: {IsSample(num)}\n" +
                $"делится без остатка на 2, 5, 3, 6, 9: {IsDiv23569(num)}");
            Console.ReadLine();
        }
        static bool IsPositive(double num) { return num >= 0 ? true : false; }
        static bool IsSample(double num)
        {
            int countDiv = 0, i = 1;
            do
            {
                if (num % i == 0) countDiv += 1;
                i++;
            } while (num >= i);
            return (countDiv == 2 ? true : false);
        }
        static bool IsDiv23569(double num)
        {
            foreach (int item in new int [] {2, 3, 5, 6, 9 })
            {
                if (num % item == 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
