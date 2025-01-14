using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class tuts2
    {
        public static void crazy()
        {
            //Converting strings to int 
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNum = "-9000000000";
            long bigNum = Convert.ToInt64(textBigNum);
            Console.WriteLine(bigNum);

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPrecision = "5.000000002";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "-14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

           


            Console.ReadLine();
        }
    }
}
