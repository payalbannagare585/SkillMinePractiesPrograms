using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class DivByFive
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number.");
            num=int.Parse(Console.ReadLine());

            if(num%5==0 )
            {
                Console.WriteLine("Divisible By 5.");
            }
            else
            {
                Console.WriteLine("Not Divisible By 5.");
            }
        }
    }
}
