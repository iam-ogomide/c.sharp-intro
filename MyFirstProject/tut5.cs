using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut5
    {
        public static void crazyi()
        {
            //If statements == > >= < <= != || &&
            Console.WriteLine("Enter your age:");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine(" and your age is " + age);

            //if (age >= 18 && age <=25)
            //{
            //    Console.WriteLine("You are 18 and older");
            //}
            //else if (age >= 26)
            //{ Console.WriteLine("You are 25 and older");
            //}
            //else if(age < 18)
            // {
            //    Console.WriteLine("Gerrout of the club");
            //}




            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are 18 and older");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 25 and older");
                }
                else if (age < 18)
                {
                    Console.WriteLine("Gerrout of the club");
                }

            }


            // mini class
            Console.Write("write your first number");
            string numberAinput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAinput);


            Console.Write("write your second number");
            string numberBinput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBinput);

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + "x" + numberB + ":");
            string answerInput = Console.ReadLine();
            int actualanswer = Convert.ToInt32(answerInput);

            if (answer == actualanswer)
            {
                Console.WriteLine("Vey good");
            }
            else
            {
                Console.WriteLine("Exit the exam");
            }


            Console.ReadLine();
        }
    }
}
