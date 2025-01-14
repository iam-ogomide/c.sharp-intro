using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.InteropServices;

namespace MyFirstProject
{
    internal class tut23
    {
        public static void jambazz(string[] args)
        {
            //Optional parameters
            int result = Add(5);
            Console.WriteLine(result);






            //Out parameters
            List<string> shoppinglist = new List<string>()
            {
                "Coffee", "Milk"
            };

            Console.WriteLine(shoppinglist.IndexOf("Milk"));

            //anotyher way to rewrite the code above
            int index = -1;

            for (int i = 0; i < shoppinglist.Count; i++)
            {
                if (shoppinglist[i].ToLower().Equals("coffeeh"))
                {
                    index = i;
                }
            }

            //Console.WriteLine(index);
            Console.WriteLine(index > -1 ? "Found" : "TYpe again");





            Console.ReadLine();
        }

        //static int Add(int x, int y = 50) { 
        //    return x + y;
        //}

        static int Add(int x, [Optional] int y)
        {
            return x + y;
        }
    }
}
