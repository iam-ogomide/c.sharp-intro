using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Test
    {
        public static void something()
        {
            Console.WriteLine("");
        }
    }

    internal class tut20
    {
        public static void dupe()
        {
            //Functions - They can also be called method, they improve the readablilty and usbaility of your code.
            //static means we can access it everywhere and anywhere
            //public means everything has access to it

            Test.something();

            WelcomeMessage();




            Console.ReadLine();
        }


        static void WelcomeMessage()
        {
            Console.WriteLine("Hello bish");
        }
    }
}
