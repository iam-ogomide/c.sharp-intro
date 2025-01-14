using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut22
    {
        public static void mar()
        {
            //Function parameters
            Console.WriteLine(Add(12, 12));
            /*
                        int num = ReadInt();
                        Console.WriteLine(num);*/

            //using the two functios we created
            int firstNum = ReadInt("Read First number: ");
            int secondNum = ReadInt("Read Second number: ");
            Console.WriteLine(Add(firstNum, secondNum));


            //working with strings
            string name = ReadString("Enter your name:");
            int age = ReadInt("Enter your age");
            string details = UserDetails(name, age);

            Console.WriteLine(details);





            Console.ReadLine();
        }

        static int ReadInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static string ReadString(string message)
        {
            Console.WriteLine($"{message}");
            return Console.ReadLine();
        }
        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}";
        }

    }
}
