using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingNumbers
{
    //how to swap two numbers without using a temp variable in C#.
    class SwappingNumbers
    {
        static void Main(string[] args)
        {
            //declaration
            int first, second;
            
            //initializing
            first = 100;
            second = 200;

            //logic
            first = first + second;
            second = first - second;
            first = first - second;

            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());

            Console.ReadLine();
        }
    }
}
