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
            List<int> numbers = new List<int>();
            string userInput;
            string sumCommand = "sum";
            string exitCommand = "exit";
            int sumNumbers = 0;
            bool isOpen = true;

            while (isOpen == true)
            {
                numbers.Add(GetNumber());

                Console.Clear();
                Console.WriteLine("Найти сумму - sum" +
                                  "\nВыйти - exit" +
                                  "\nПродолжить - enter");
                userInput = Console.ReadLine();

                if (userInput.Equals(sumCommand))
                    SumNumbers(ref numbers, ref sumNumbers);

                if (userInput.Equals(exitCommand))
                    isOpen = ExitProgram();

                Console.Clear();
            }

        }

        static int GetNumber()
        {
            int number;
            string numberText;

            do
            {
                Console.WriteLine("Введите число, которое хотите добавить:");
                numberText = Console.ReadLine();
            } while (int.TryParse(numberText, out number) == false);

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