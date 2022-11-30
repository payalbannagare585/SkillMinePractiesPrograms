using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //take value from user ways 
            int num1, num2, result;
            Console.WriteLine("Enter the value of 1st number: ");
            num1 = int.Parse(Console.ReadLine());//first way

            Console.WriteLine("Enter the value of 2nd number: ");
            num2 = int.Parse(Console.ReadLine());//first way

            result = num1 + num2;
            Console.WriteLine(result);

            //second way
            int n1, n2, res;
            Console.WriteLine("Enter the value of number: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of number: ");
            n2 = int.Parse(Console.ReadLine());
            res = n1 + n2;

            Console.WriteLine(res);

            //to accept char type value

            char ch;
            Console.WriteLine("Enter the value of Charecter: ");
            ch = Convert.ToChar(Console.ReadLine());


        }
    }
}
