using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU00030191_Unit1CurrencyConverteCR
{
    class Program
    {
        static void Main(string[] args)
        {;
            Console.Write("Please Enter a number");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter a second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter yet a third and final number, please");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double sum = num + Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total=" + sum);
            Console.ReadKey();

            //Currency from Sum
            Console.WriteLine("Amount in US dollars = {0,C}", sum);
            Console.WriteLine("Amount in Yen = {0:JPY}", sum);
            Console.WriteLine("Amount in Krona = {0:SEK}", sum);
            Console.WriteLine("Amount in Baht = {0:THB}", sum);

            //min max average
            double[] myarray = { num + num2 + num3 };

           


            Console.WriteLine ("The average value is");
            Console.WriteLine(myarray.Average());

            //min
            Console.WriteLine("The minimum number is");
            Console.WriteLine(myarray.Min());

            //Max
            Console.WriteLine("The maximum number is");
            Console.WriteLine(myarray.Max());

            








            

            




        }
    }
}
