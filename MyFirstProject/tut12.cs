using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut12
    {
        public static void rain()
        {
            // TryParse is a method commonly used for converting strings to other data types safely. 
            Console.Write("Enter a number: ");
            string input = Console.ReadLine(); // Get user input

            // Try to parse the input to an integer
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine("You entered: " + number);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }



            //Example 2

            bool success = true;

            while (success)
            {
                Console.WriteLine("Enter a number: ");
                string numInput = Console.ReadLine();


                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }




            Console.ReadLine();
        }
    }
}
