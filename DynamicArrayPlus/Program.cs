using System;
using System.Collections.Generic;

namespace DynamicArrayPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> userNumbers = new List<int>();

            string commandExit = "exit";
            string commandSum = "sum";
            string userInput;

            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("\nВведите ваши числа.");
                Console.WriteLine($"Для суммирования чисел введите {commandSum}." +
                                    $"\nДля выхода из программы введите {commandExit}.");

                userInput = Console.ReadLine();

                Console.Clear();

                if (userInput == commandSum)
                {
                    GetSumNumbers(userNumbers);
                }
                else if (userInput == commandExit)
                {
                    isWork = false;
                }
                else
                {
                    AddNumber(userNumbers, userInput);
                }

                for (int i = 0; i < userNumbers.Count; i++)
                {
                    Console.Write(userNumbers[i] + " ");
                }
            }
        }

        static void AddNumber(List<int> userNumbers, string userInput)
        {
            if (Int32.TryParse(userInput, out int userNumber))
            {
                userNumbers.Add(userNumber);
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
            }
        }

        static void GetSumNumbers(List<int> userNumbers, int sum = 0)
        {
            foreach (int userNumber in userNumbers)
            {
                sum += userNumber;
            }

            Console.WriteLine($"Сумма ваших чисел: {sum}");
        }
    }
}
