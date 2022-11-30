using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class OddEven
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter value of n: ");
            n=int.Parse(Console.ReadLine());

            if(n%2==0 )
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is Odd");
            }

        }
    }
}
