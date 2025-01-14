using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut31
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
        public static void arn()
        {
            //Classes with functions

            //Calling the structure our
            Person person = new Person("Abe", 23);

            Console.WriteLine(ReturnDetails(person.name, person.age));




            Console.ReadLine();
        }

        static string ReturnDetails(string name, int age)
        {
            return $"Name :{name}\nAge: {age}";
        }

    }
}
