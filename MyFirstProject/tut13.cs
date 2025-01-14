using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut13
    {
        public static void rand()
        {
            //Exersice 1
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }

            //Exercise 2 
            for (int i = 1;i <= 15;i++)
            {
                if(i % 3 == 0 && i % 5 ==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 ==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 ==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }




            Console.ReadLine();
        }
    }
}
