using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut4
    {
        public static void crazzi()
        {
            //Using the console for reading values
            //difference between write and writeLine is that writeLine will have a terminator at the end of the line to tell the console that it wants to push everything after it to the next line
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.WriteLine("Enter your age:");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.Write("Your name is:");
            Console.Write(name);
            Console.Write("Your age is:");
            Console.Write(age);


            //Concat
            Console.WriteLine("Your name is " + name + " and your age is " + age);




            Console.ReadLine();
        }
    }
}
