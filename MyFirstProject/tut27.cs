using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut27
    {
        public static void tein()
        {
            //Exception Handling
            //Unhandled means that we havent got anything specific that will handle this exception causing the program to close
            //if you type in exception in the brackets for catch, it will catch every single exception - The problem with this is that you face some diffculties if you want to output some specific messages


            //Examples exceptions that we wanna target
            //System.FormatException
            //System.OverflowException



            //we are puting it inside a while loop to give us more chances to get the a prover int value
            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);

                    looping = false;
                }
                catch (OverflowException)
                {

                    Console.WriteLine("Enter a number less that 2 billion");
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please enter numbers");
                }
                catch (Exception)
                {

                    Console.WriteLine("Something is wrong");
                }
            }


            //Printing error messages
            try
            {
                Console.Write("Enter a number: ");
                int numa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numa);

            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }



            Console.ReadLine();
        }
    }
}
