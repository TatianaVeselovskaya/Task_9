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
            double a = 0, b = 0, res = 0;
            int d = 0;
            string sta, stb, std;
            Console.WriteLine("*****Ваш личный калькулятор***");
            Console.Write("Введите первое число: ");
            sta = Console.ReadLine();
            if (double.TryParse(sta, out a))
            {
                Console.Write("Введите второе число: ");
                stb = Console.ReadLine();
                if (double.TryParse(stb, out b))
                {
                    a = Convert.ToDouble(sta);
                    b = Convert.ToDouble(stb);
                    Console.WriteLine("Список доступных операций:");
                    Console.WriteLine("1: Сложение");
                    Console.WriteLine("2: Вычитание");
                    Console.WriteLine("3: Произведение");
                    Console.WriteLine("4: Часное");
                    Console.Write("Введите номер операции: ");
                    std = Console.ReadLine();
                    if (int.TryParse(std, out d))
                    {
                        d = Convert.ToInt32(std);
                        if (d >= 1 && d <= 4)
                        {
                            switch (d)
                            {
                                case 1: res = a + b; break;
                                case 2: res = a - b; break;
                                case 3: res = a * b; break;
                                case 4: res = a / b; break;
                            }
                            Console.WriteLine("Реультат: " + res);
                        }
                        else 
                        { 
                            Console.WriteLine("Несуществует операции: " + std); 
                        }
                    }
                    else 
                    { 
                        Console.WriteLine("Несуществует операции: " + std); 
                    }
               
                
                }
                    else 
                    {
                        Console.WriteLine("Введенное: " + stb + " не является числом"); 
                    }
            }
            else 
            { 
                Console.WriteLine("Введенное: " + sta + " не является числом"); 
            }

            Console.ReadKey();
        }
    }
}
