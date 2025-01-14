using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut1
    {
        public static void DoSomething()
        {
            //Number based datatypes - int,long,double, float,decimal(M) 
            int age = 23;
            Console.WriteLine(age);

            long bigNum = 9000000000L;

            Console.WriteLine(bigNum);

            //Text based datatypes - string, char
            string name = "You";
            char letter = 'a';

            Console.WriteLine(letter);
            Console.WriteLine(name);


            Console.ReadLine();
        }
    }
}
