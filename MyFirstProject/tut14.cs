using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut14
    {
        public static void jain()
        {
            //String Formatting
            string name = "Aba";
            int age = 23;

            Console.WriteLine("Name: " + name + "\nAge: " + age);
            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);

            //String Interpolation - uses $ as reference
            Console.WriteLine($"Your name is {name} and your age is {age}");

            //String equals functions
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare)) //message == compare(same thingy) .equals is concerned with the values than where they are in your memory
            {
                Console.WriteLine("Same nau");
            }
            else
            {
                Console.WriteLine("Digferent value");
            }


            //String iteration - looping
            Console.WriteLine(message[0]);

            //Using the sleep function inside the threading library - this will suspend the current thread for a specified number of milliseconds.  1000ms = 1sec
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
                Thread.Sleep(250);
            }




            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('o'))
                {
                    contains = true;
                }

            }

            Console.WriteLine(contains);


            //String is Null or empty
            Console.WriteLine("Enter your name");
            string names = "";

            Console.WriteLine($"Your name is {names}");

            if (names != "")
                Console.WriteLine("0");

            if (names.Equals(""))
                Console.WriteLine("1");

            if (!string.IsNullOrEmpty(names))
                Console.WriteLine("2");


            //The proper way to apply isNullOrEmpty

            if (!string.IsNullOrEmpty(names))
            { 
                if (name.Equals("Hello"))
                {
                    Console.WriteLine("Correct");
                }
            }




            Console.ReadLine();
        }
    }
}
