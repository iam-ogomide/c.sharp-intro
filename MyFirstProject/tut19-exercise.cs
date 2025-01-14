using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut19_exercise
    {
        public static void shylan()
        {
            //exercise
            //even odd numbers

            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Printing even numbers:");
            foreach (int i in even)
            {
                Console.WriteLine($"{i}");
            };


            Console.WriteLine(Environment.NewLine + "Printing odd numbers:");
            foreach (int i in odd)
            {
                Console.WriteLine($"{i}");
            };



            ///Exercise Array of multiples
            int num = 7;
            int length = 5;
            int[] result = new int[length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = num * i;
            }

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }



            Console.ReadLine();
        }
    }
}
