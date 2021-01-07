using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Odd and Even number
            //int num;
            //Console.Write("Enter a number to check if its odd or not : ");
            //num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.Write("Even number");
            //}
            //else
            //{
            //    Console.Write("Odd number");
            //}


            //How to find all the even number from 0 to 100:


            for(int i = 0; i <= 100; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
