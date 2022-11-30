using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class TernaryGretestNum
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the value of 1st Number: ");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of 2nd Number: ");
            num2=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of 3rd Number: ");
            num3=int.Parse(Console.ReadLine());


            string result = (num1 > num2) && (num1 < num3) ? "the value of num1 is greateast among three." : (num2 > num3) ? "the value of num2 is greatest among three." : "the value of num3 is greatest among three.";

            Console.WriteLine(result);
        }
    }
}
