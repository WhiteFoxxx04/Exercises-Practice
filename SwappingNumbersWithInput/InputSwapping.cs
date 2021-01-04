using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingNumbersWithInput
{
    class InputSwapping
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Input value for a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the value for b:");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swapping: ");
            Console.WriteLine("Value of a: " + a);
            Console.WriteLine("Value of b: " + b);

            Console.ReadLine();
        }
    }
}
