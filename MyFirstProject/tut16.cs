using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut16
    {
        public static void jard()
        {
            //Array Intro - are ways we can store multiple variables of the same datatype in one group. Instantiate is what we use turn something into anew class

            int[] numbers = new int[5];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //Using a for loop to loop through all the numbers. If you want to go through specific cases like a range of vales. this is the suitable opotion
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}");
            }

            //another way to display it if you want to go through every single value
            foreach (int i in numbers)
            {
                Console.WriteLine($"{i}");
            }


            //Triangle exercise
            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.WriteLine($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine(angleSum);



            //Array sorting
            //int[] numbers = new int[]
            //{
            //    3,4,2,8,2,9,4,1
            //};

            Array.Sort(numbers);
            //Array.Reverse(numbers); 

            foreach (int number in numbers)
            {
                Console.Write($"{number}");
            }

            //Array Clearing

            int[] nad = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            //sets a range of elements in an array to the default value of each element type
            Array.Clear(nad, 0, nad.Length);

            for (int i = 5; i < 10; i++)
            {
                nad[i] = default;
            }
            foreach (int number in nad)
            {
                Console.Write($"{number}");
            }


            //Array Indexof
            int[] nare = new int[] {
                90,100,22, 67, 45
            };

            Console.Write("Enter number to search: ");

            int search = Convert.ToInt32(Console.ReadLine());
            int position = Array.IndexOf(nare, search);

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at postion {position}");
            }
            else
            {
                Console.WriteLine($"Number {search} is not available");
            }



            Console.ReadLine();
        }
    }
}
