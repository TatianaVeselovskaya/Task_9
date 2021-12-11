using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор");

            Console.Write("Введите целое число Х=");
            double a = 0;
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите целое число Y=");
            double b = 0;
            try
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите код операции:");
            Console.WriteLine("1: Сложение");
            Console.WriteLine("2: Вычитание");
            Console.WriteLine("3: Произведение");
            Console.WriteLine("4: Часное");
            Console.Write("Введите номер операции: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Рузультат: {a} + {b} = " + (a + b));
                    break;
                case "2":
                    Console.WriteLine($"Рузультат: {a} - {b} = " + (a - b));
                    break;
                case "3":
                    Console.WriteLine($"Рузультат: {a} * {b} = " + (a * b));
                    break;
                case "4":
                    try
                    {
                        Console.WriteLine($"Рузультат: {a} / {b} = " + (a / b));
                    }
                    catch
                    {
                        Console.WriteLine("Деление на 0");
                    }
                    break;
                default:
                    Console.WriteLine("Некорректная операция");
                    Console.ReadKey();
                    return;
            }

            Console.ReadKey();
        }
    }
}
