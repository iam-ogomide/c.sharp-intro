using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Threading;
using System.Runtime.InteropServices;

namespace MyFirstProject
{

   
    internal class Program

    {

        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            //setter and getter

            //Calling the structure our
            Person person = new Person("Abe", 23);

            Console.WriteLine(ReturnDetails(person.name, person.age));


            person.name = "Harry";
            person.age = 21;

            Console.WriteLin
            



            Console.ReadLine();
        }

        static string ReturnDetails(string name, int age)
        {
            return $"Name :{name}\nAge: {age}";
        }



    }
}
