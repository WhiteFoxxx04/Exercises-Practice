using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the number to find out if its a Prime Number or Not: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if(n % i == 0)
                {
                    Console.Write("Not a Prime Number");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Prime Number");

            Console.Read();
        }
    }
}
