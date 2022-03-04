using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradeDynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SumCommand = "sum";
            const string ExitCommand = "exit";

            List<int> numbers = new List<int>();
            string userInput;
            int sumNumbers = 0;
            bool isOpen = true;

            while (isOpen == true)
            {
                Console.Clear();
                Console.WriteLine("Найти сумму - sum" +
                                  "\nВыйти - exit" +
                                  "\nПродолжить - enter");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case SumCommand:
                        SumNumbers(ref numbers, ref sumNumbers);
                        break;
                    case ExitCommand:
                        isOpen = ExitProgram();
                        break;
                    default:
                        numbers.Add(GetNumber(userInput));
                        break;
                }
            }
        }

        static int GetNumber(string numberText)
        {
            int number;

            if (int.TryParse(numberText, out number) == false)
            {
                Console.WriteLine("Введено не число");
                Console.ReadKey(true);
            }

            return number;
        }

        static void SumNumbers(ref List<int> numbers, ref int sumNumbers)
        {
            sumNumbers = 0;

            for (int index = 0; index < numbers.Count; index++)
            {
                sumNumbers += numbers[index];
            }

            Console.Clear();
            Console.WriteLine($"Сумма чисел - {sumNumbers}");
            Console.ReadKey();
        }

        static bool ExitProgram()
        {
            Console.Clear();
            Console.WriteLine("Выход ...");
            return false;
        }
    }
}