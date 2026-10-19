//***********************************************************
//* Практическая работа № 11                                *
//* Выполнил:Разумов М. И., группы 2-ИСП                    *
//* Задание: составить  программу работы линейного алгоритма*
//***********************************************************
using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
                    string keyword = "password:";
                    string text;
                    int simvol = 5;
                    string zamena = "*****";
                    Console.Write("Введите строку: ");
                    text= Console.ReadLine();
                    StringBuilder result = new StringBuilder();
                    int currentIndex = 0;
                    int foundIndex = text.IndexOf(keyword, currentIndex);
                    while (foundIndex != -1)
                    {
                        result.Append(text.Substring(currentIndex, foundIndex - currentIndex));
                        result.Append(keyword);
                        int startReplace = foundIndex + keyword.Length;
                        if (startReplace + simvol <= text.Length)
                        {
                            result.Append(zamena);
                        }
                        else
                        {
                            int remaining = text.Length - startReplace;
                            result.Append(new string('*', remaining));
                        }
                        int charsToSkip = keyword.Length + simvol;
                        currentIndex = foundIndex + charsToSkip;
                        if (currentIndex >= text.Length) break;
                        foundIndex = text.IndexOf(keyword, currentIndex);
                    }
                    if (currentIndex < text.Length)
                    {
                        result.Append(text.Substring(currentIndex));
                    }
                    Console.WriteLine("преобразованная строка: ");
                    Console.Write(result.ToString());
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
                int g = -1;
                while (g < 0)
                {
                    r = Convert.ToDouble(Console.ReadLine());
                    if (r == 0)
                    {
                        h = 0;
                        g = 1;
                    }
                    else if (r == 1)
                    {
                        h = 1;
                        g = 1;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка: нужно ввести 0 или 1. Программа завершается.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();// Задержка
            }
        }
    }
}