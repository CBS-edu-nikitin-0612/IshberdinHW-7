using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double ExchangeRates, value;
            do
            {
                Console.WriteLine("Введите значение: ");
                value = Convert.ToDouble(Console.ReadLine().ToString().Replace('.', ','));
                Console.WriteLine("Введите курс валют: ");
                ExchangeRates = Convert.ToDouble(Console.ReadLine().ToString().Replace('.', ','));

                Console.WriteLine(value * ExchangeRates);
            }
            while (true);
        }
    }
}
