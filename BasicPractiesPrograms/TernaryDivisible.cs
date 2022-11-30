using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class TernaryDivisible
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number: ");
            num = int.Parse(Console.ReadLine());

        

            string result = (num % 9 == 0 && num % 5 == 0) ? "Number is divisible by 9 and 5 " : "Number is not divisible by 9 and 5";

            Console.WriteLine(result);

        }
    }
}
