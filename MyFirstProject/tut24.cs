using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut24
    {
        public static void wain()
        {
            //Named parameters

            string nameInput = "Aba";
            int ageInput = 23;
            string addressInput = "The other side";

            PrintDetails(name: nameInput, age: ageInput, address: addressInput);



            Console.ReadLine();
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address:  {address}");
        }
    }
}
