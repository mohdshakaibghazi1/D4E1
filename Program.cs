using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4A4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
           number= int.Parse(Console.ReadLine());
            if (number >0)
            {
                Console.WriteLine("number is positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("number is zero");
            }
            else
            {
                Console.WriteLine("number is negative");
            }
            var result=number%2==0 ? "number is even " : "number is odd";
            Console.WriteLine(result);
        }
    }
}
