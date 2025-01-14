using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut3
    {
        public static void crazz()
        {
            //Opertaions
            int age = 30;
            age++;
            Console.WriteLine(age);

            double par = 40;
            par /= 10;
            Console.WriteLine(par);


            string name = "Aba";
            name += "is joking";
            Console.WriteLine(name);

            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(i);


            //playing around with const
            const int vat = 20;

            int balance = 1000;

            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(vat);


            //Exercise odd even checker
            int num1 = 10;
            int num2 = 20;

            var total = num2 % num1;
            Console.WriteLine(total);

            num1 = 3;
            total = num2 % num1;
            Console.WriteLine(total);


            Console.ReadLine();
        }
    }
}
