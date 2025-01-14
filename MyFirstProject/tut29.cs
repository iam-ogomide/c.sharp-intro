using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut29
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthmonth;
            public int number;

            //using a constructor
            public Person(string name, int age, int birthMonth, int number)
            {
                this.name = name;
                this.age = age;
                this.birthmonth = birthMonth;
                this.number = number;
            }
        }
        public static void bnxn()
        {
            //Structures - allows us to store different datatypes inside one datatype
            //string name = "Aba";
            //int age = 23;
            //int birthmonth = 3;

            //Person person;

            //person.name = "Aba";
            //person.age = 23;
            //person.birthmonth = 3;

            //Console.WriteLine($"{name} - {age} - {birthmonth}");

            //string newName = ReturnPerson(out int newAge);
            //Console.WriteLine($"{newName} - {newAge}");



            //Calling out the second returnperson
            Person person = ReturnPerson2();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthmonth} - {person.number}");




            Console.ReadLine();
        }

        static string ReturnPerson(out int age)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            return name;
        }


        //Another way of setting it up
        static Person ReturnPerson2()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birthMonth");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your phone number");
            int number = Convert.ToInt32(Console.ReadLine());



            //Person person;

            //person.name = name;
            //person.age = age;
            //person.birthmonth = birthMonth;
            //person.number = number;


            //return person;

            //Calling the constructor
            return new Person(name, age, birthMonth, number);
        }
    }
}
