using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get a factorial: ");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of the given number is : " + fact);
        }
    }
}
