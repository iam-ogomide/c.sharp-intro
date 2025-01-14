using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut15_exercise
    {
        public static void dada()
        {
            //Exercise 1 - Print string in reverse

            Console.WriteLine("Enter a random message: ");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }


            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(message[i]);
            }


            //Exercise 2
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter your password again: ");
            string newPassword = Console.ReadLine();

            if (password.Equals(newPassword))
            {
                Console.WriteLine("Correct password");
            }
            else if (password == "" || newPassword == "")
            {
                Console.WriteLine("Please put a password");
            }
            else
            {
                Console.WriteLine("Incorrect password");
            }

            //crazier solution
            if (!password.Equals(string.Empty) && !newPassword.Equals(string.Empty))
            {
                if (password.Equals(newPassword))
                {
                    Console.WriteLine("Correct Pass");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

            else
            {
                Console.WriteLine("Enter a password nau");
            }

            Console.ReadLine();
        }
    }
}
