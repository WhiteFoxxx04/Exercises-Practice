using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationOfUserInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, result;
            Console.WriteLine("Enter value for Num1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for Num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for Num3: ");
            num3 = int.Parse(Console.ReadLine());

            result = num1 * num2 * num3;

            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
