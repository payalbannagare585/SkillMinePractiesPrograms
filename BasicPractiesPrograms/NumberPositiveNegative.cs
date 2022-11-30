using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class NumberPositiveNegative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the value of number: ");
            num=int.Parse(Console.ReadLine());

            if(num>0) 
            {
                Console.WriteLine("Number is Positive.");
            }
            else if(num==0)
            {
                Console.WriteLine("Number is Zero.");
            }
            else
            {
                Console.WriteLine("Number is Negative.");
            }

        }
    }
}
