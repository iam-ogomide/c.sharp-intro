 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut30
    {
        //Using Structure
        //struct Person
        //{
        //    public string name;
        //    public int age;


        //    //using a constructor
        //    public Person(string name, int age) {
        //        this.name = name;
        //        this.age = age; 

        //    }
        //}


        //Using classes

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
        public static void vini()
        {
            //Classes - main difference between this and sturcture is that you dont have to give it a default value inside the constructor 

            //Calling the structure our
            Person person = new Person("Abe", 23);

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);



            Console.ReadLine();
        }

    }
}
