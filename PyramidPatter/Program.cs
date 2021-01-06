using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pyrmaid Pattern using *
            int x, y, z;

            for (x = 1; x <= 5; x++)
            {
                for (y = x; y < 5; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
