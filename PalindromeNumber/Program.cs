using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to check if its Palindrome or not: ");
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            int rem;
            //assigning temp the num which we are inputing first time to temp variable
            int temp = num;

            //first reverse the input number 
            while (num != 0)
            {
                rem = num % 10;
                result = (result * 10) + rem;
                num = num / 10;
            }
            //then assisgn the reverse num to temp variable
            num = temp;

            //checking if the num is == to result
            if (num == result)
            {
                Console.WriteLine("Its a Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not a Palindrome Number");
            }



            string s, revs = "";
            Console.WriteLine("Enter a string: ");
            s = Console.ReadLine();

            for (int i = s.Length-1; i >= 0; i--)//reversing the string 
            {
                revs += s[i].ToString();
            }
            //Checking for the reverse
            Console.WriteLine("Reverese of a string is : {0} ", revs);

            if (revs == s)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }
    }
}
