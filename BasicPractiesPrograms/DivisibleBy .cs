using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class DivisibleBy
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number.");
            num=int.Parse(Console.ReadLine());

            if(num%3==0 && num%9==0)
            {
                Console.WriteLine("Divisible By 3 and 9.");
            }
            else
            {
                Console.WriteLine("Not Divisible By 3 and 9.");
            }
        }
    }
}
