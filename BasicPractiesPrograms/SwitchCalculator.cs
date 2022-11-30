using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class SwitchCalculator
    {
        static void Main(string[] args)
        {
            int num1, num2, operation;
            Console.WriteLine("Enter the value of first number:");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of second number:");
            num2=int.Parse(Console.ReadLine());

            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Substraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");

            operation=int.Parse(Console.ReadLine());

            switch (operation) { 
            
                case 1:
                    Console.WriteLine("The addition is: {0}", num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("The Substraction is: {0} ",num1-num2);
                    break;
                case 3:
                    Console.WriteLine("The Multiplication is:{0} ", num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("The Division is:{0} ", num1 / num2);
                    break;
                    default:
                    Console.WriteLine("Enter the correct Operation");
                    break;
            }
        }
    }
}
