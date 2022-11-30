using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class TernaryOddEven
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter value of number.");
            num=int.Parse(Console.ReadLine());

            switch (num % 2)
            {
                case 0 :
                    Console.WriteLine("Number is even.");
                    break;
                case 1:
                    Console.WriteLine("Number is odd.");
                    break;
            }
        }
    }
}
