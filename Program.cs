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
            double repetitionCycle, loopForContinuationOrTermination;
            repetitionCycle = 0;
            while (repetitionCycle < 1)
            {
                Console.Clear(); //Очистка 
                Console.Title = "Практическая работа №11";
                Console.WriteLine("Здравствуйте");
                try
                {
                    string line = "*****";
                    string key = "password:";
                    char[] line1 = line.ToCharArray();//перевод строки в массив 
                    char[] key1 = key.ToCharArray();
                    int repetitionOnTheInput = 0;
                    Console.WriteLine("Если вы хотитн заменить 5 символов то введите (password:)");
                    Console.WriteLine("Введите текст: ");
                    while (repetitionOnTheInput == 0)
                    {
                        string text = Console.ReadLine();
                        if (String.IsNullOrEmpty(text))//проверка на пустоту в строке
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: Строка пустая, введите строку!");
                            Console.ForegroundColor = ConsoleColor.White;
                            repetitionOnTheInput = 0;
                        }
                        else
                        {
                            int theLastCharacter = text.Length;//размер массива
                            repetitionOnTheInput = 1;
                            char[] text1 = text.ToCharArray();
                            int index = 0;
                            int currentIndex = 0;

                            if (index >= 0)
                            {
                                while (index >= 0)//повторение если несколько password
                                {
                                    index = text.IndexOf(key, currentIndex);
                                    int j = 0;
                                    int substitutionLimit = index + 14;
                                    for (int i = index + 9; i < substitutionLimit; i++)//замена на *
                                    {
                                        if (theLastCharacter > i)
                                        {
                                            text1[i] = line1[j];
                                            j = j++;
                                        }
                                    }
                                    text = new String(text1);
                                    currentIndex = index + 9;
                                }
                            }
                            Console.WriteLine($"Переобразованный текст:{text}");
                        }

                    }
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
                int check = -1;
                while (check < 0)
                {
                    try
                    {
                        loopForContinuationOrTermination = Convert.ToDouble(Console.ReadLine());
                        if (loopForContinuationOrTermination == 0)
                        {
                            repetitionCycle = 0;
                            check = 1;
                        }
                        else if (loopForContinuationOrTermination == 1)
                        {
                            repetitionCycle = 1;
                            check = 1;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: нужно ввести 0 или 1.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
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
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();// Задержка
            }
        }
    }
}