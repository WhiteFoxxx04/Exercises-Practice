using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    //Write a c# program to print fibonacci series without using recursion and using recursion.
    //In case of fibonacci series, next number is the sum of previous two numbers 
    //for example 0, 1, 1, 2, 3, 5, 8, 13, 21 etc.The first two numbers of fibonacci series are 0 and 1.
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1
            for(i=2; i<number; i++) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
