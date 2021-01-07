using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing Largest number:

            int a, b, c;
            Console.WriteLine("Enter a number for a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number for b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number for c: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Value of A is greater than B & C");
            }
            else if(b > a && b > c)
            {
                Console.WriteLine("Value of B is greater than A & C");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Value of C is greater than A & B");
            }
            else
            {
                Console.WriteLine("Dont put the same value");
            }

        }
    }
}
