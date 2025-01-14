using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tut17
    {
        public static void pain()
        {
            //List 
            //List<int> listNumbers = new List<int>()
            //{ 
            //    1,2,3,4,5,6,7,8, 
            //};

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }


            //in array we have length , but in list we have count of the items
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }
}
