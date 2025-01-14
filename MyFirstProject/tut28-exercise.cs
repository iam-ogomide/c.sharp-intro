using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut28_exercise
    {
        public static void suij()
        {
            //Custom try parse Exercise
            bool success = false;

            try
            {
                Console.WriteLine("Enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine(success ? "Yay" : "No");



            //Using the tryparse, it will take in a string and output a result
            Console.WriteLine("Enter a number");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Yay");
            }
            else
            {
                Console.WriteLine("Oh no");
            }

            Console.ReadLine();
        }


        static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
