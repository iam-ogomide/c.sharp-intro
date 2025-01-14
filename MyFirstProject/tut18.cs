using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut18

    {
        public static void suiiin()
        {
            //Dictonary - are generic collections that store key values pair in no particular order. The key and value can be any datatype
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                {1, "Joe" },
                {2, "Moe" },
                {3, "Jae" },
                {4, "Boeat" },
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.Write($"{pair.Key} - {pair.Value}");
            }

            //using for each to print it out
            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //using string
            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Aba" },
                {"Science", "Test" }
            };

            Console.WriteLine(teachers["Math"]);

            //A more better way of doing it

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);
            }
            else
            {
                Console.WriteLine("Not found");
            }




            ///Instead of usiung the remove function we can use an if statement
            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }


            Console.ReadLine();
        }

    }
}
