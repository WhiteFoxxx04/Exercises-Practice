using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check");
            int num = int.Parse(Console.ReadLine());
            int rem;
            int cube;
            int result = 0;
            int temp = num;

            while (num !=0)
            {
                rem = num % 10;
                cube = rem * rem * rem;
                result = result + cube;
                num = num / 10;
            }

            num = temp;
            if (num == result)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }
        }
    }
}
