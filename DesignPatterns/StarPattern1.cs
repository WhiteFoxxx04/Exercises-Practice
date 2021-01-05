using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class StarPattern1
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the number for pattern");
            c = int.Parse(Console.ReadLine());

            for (a = 0; a <= c; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            
        }
    }
}
    