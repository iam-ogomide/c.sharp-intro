using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut7
    {
        public static void senior()
        {
            //For Loops - Allows us to loop a certain number of times depending on the parameter we give it
            //3 different section- first is the declaration&initilization, second is the condition, the third is increment

            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine(i);
            // }


            //Mini class
            Console.Write("How many times do you want this to loop");
            string loopie = Console.ReadLine();
            int loopCounter = Convert.ToInt32(loopie);

            if (loopCounter <= 0)
            {
                Console.WriteLine("Use a number higher than 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine("Youngins");
                }
            }




            Console.ReadLine();
        }
    }
}
