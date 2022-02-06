using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string @operator;
            do
            {
                Console.WriteLine("Введите первое значение: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе значение: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите знак действия: ");
                @operator = Console.ReadLine();
                Console.Write("Результат: ");
                if (@operator == "+") Add(a, b);
                else if (@operator == "-") Sub(a, b);
                else if (@operator == "*") Mul(a, b);
                else if (@operator == "/") Div(a, b);

            }
            while (@operator == "exit");
        }
        static void Add(int a, int b) { Console.WriteLine(a + b); }
        static void Sub(int a, int b) { Console.WriteLine(a - b); }
        static void Mul(int a, int b) { Console.WriteLine(a * b); }
        static void Div(int a, int b) { Console.WriteLine(b == 0 ? "Деление на ноль" : a / b); }


    }
}
