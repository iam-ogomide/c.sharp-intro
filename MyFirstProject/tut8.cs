using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut8
    {
        public static void ain()
        {
            //While Loops - you print until a condition is true

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // mini class

            Console.Write("write your first number");
            string numberAinput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAinput);


            Console.Write("write your second number");
            string numberBinput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBinput);

            int answer = numberA * numberB;
            int actualanswer = 0;

            Console.Write("What's the value of " + numberA + "x" + numberB + ":");
            Console.WriteLine();

            //while(answer != actualanswer)
            //{
            //    Console.WriteLine("Enter your answer: ");
            //    string answerInput = Console.ReadLine();
            //    actualanswer = Convert.ToInt32(answerInput);

            //    if (answer != actualanswer)
            //    {
            //        Console.WriteLine("Try Again youngin");
            //    }

            //}

            //Console.WriteLine("Well done");


            //Do while condition will only happen once
            do
            {
                Console.WriteLine("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualanswer = Convert.ToInt32(answerInput);

                if (answer != actualanswer)
                {
                    Console.WriteLine("Try Again youngin");
                }
            }
            while (answer != actualanswer);

            Console.WriteLine("Well done");









            Console.ReadLine();
        }
    }
}
