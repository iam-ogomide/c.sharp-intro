using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut21
    {
        public static void jumps()
        {
            //void functions -  is a method that does not return a value. Instead of specifying a return type (like int, string, or bool),



            //Return type - is a method that returns a value after it has completed its execution. Unlike void methods, which do not return any value, return functions specify a return type in their declaration and use the return keyword to send a value back to the caller.

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }

            foreach (var i in numbers)
            {
                Console.WriteLine($"{i}");
            }

            int[] newNumbers = CreateRandomArray();

            foreach (var item in newNumbers)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadLine();
        }

        static int ReadNumberFromConsole()
        {
            Console.WriteLine("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] CreateRandomArray()
        {
            int[] numbers = new int[]
            {
                0, 1, 2,
            };

            return numbers;
        }
    }
}
