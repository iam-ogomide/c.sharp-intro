using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut26_exercise
    {
        public static void outside()
        {
            //Traingle exercise advanced

            Console.WriteLine("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            int area = Area(width, height);
            Console.WriteLine($"The area of your triangle is {area}");



            //Sum of INT array
            int[] numbers = new int[]
            {
                    0,1,2,3,4,5,6,
            };

            int result = Sumofnumbers(numbers);

            if (result > -1)
            {
                Console.WriteLine($"The total is {result}");
            }
            else
            {
                Console.WriteLine("Cannot add empty array");
            }

            //Calling out the one for boolean
            if (Sumofnumbers(numbers, out int total))
            {
                Console.WriteLine($"The total is {total}");
            }
            else
            {
                Console.WriteLine("Cannot add empty array");
            }



            Console.ReadLine();
        }

        static int Area(int x, int y)
        {
            return (x * y) / 2;
        }

        static int Sumofnumbers(int[] numbers)
        {
            if (numbers.Length > 0)
            {
                int total = 0;

                foreach (var number in numbers)
                {
                    total += number;

                }

                return total;
            }

            return -1;
        }


        //Instead of printing out values, we want to print out either true or false
        static bool Sumofnumbers(int[] numbers, out int total)
        {
            total = 0;

            if (numbers.Length > 0)
            {
                foreach (var number in numbers)
                {
                    total += number;
                }
                return true;
            }

            return false;
        }

    }
}
