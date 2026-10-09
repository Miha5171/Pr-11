//***********************************************************
//* Практическая работа № 11                                *
//* Выполнил:Разумов М. И., группы 2-ИСП                    *
//* Задание: составить  программу работы линейного алгоритма*
//***********************************************************
using System;

namespace Пр11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, r;
            h = 0;
            while (h < 1)
            {
                Console.Clear(); //Очистка 
                Console.Title = "Практическая работа №11";
                Console.WriteLine("Здравствуйте");
                try
                {
                    Console.Write("Введите строку: ");
                    string text = Console.ReadLine();
                    string target = "password: ";
                    int giii = 5;
                        string start = "*****";

                }
                catch (FormatException fEx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {fEx.Message} ");
                }
                catch (OverflowException oEx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка переполнения: {oEx.Message} ");
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Что-то пошло не так. ошибка : " + e.Message);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Хотите запустить снова?");
                Console.WriteLine("Если да то введите 0, если нет введите 1 ");
                r = Convert.ToDouble(Console.ReadLine());
                if (r == 0)
                {
                    h = 0;
                }
                else if (r == 1)
                {
                    h = 1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: нужно ввести 0 или 1. Программа завершается.");
                    h = 1;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();// Задержка
            }
        }
    }
}