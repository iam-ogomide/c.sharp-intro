using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut25
    {
        public static void plain()
        {
            //Reference parameters -reference parameters allow you to pass arguments to a method by reference rather than by value. This means that when you pass a variable as a reference parameter, the method can modify the value of that variable, and the changes will be reflected outside the method
            //You need to modify the original variable without using a return statement.

            //int num = 10;
            //string name = "Joe";
            //Assign(ref num, ref name);
            //Console.WriteLine(name);
            //Console.WriteLine(num);


            //Example 2
            string name = "Joeed";
            Console.WriteLine("Enter your name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}");
            }
            else
            {
                Console.WriteLine("New name cannot be empty");
            }




            Console.ReadLine();
        }

        static void Assign(ref int num, ref string name)
        {
            name = "Abe";
            num = 20;
        }

        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
        }
    }
}
