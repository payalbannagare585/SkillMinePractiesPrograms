using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class ArmstrongNum
    {
        static void Main(string[] args)
        {
            int n, nu, num = 0, rem;
            Console.Write("Enter positive number :");
            n = int.Parse(Console.ReadLine());

            nu = n;
            while (nu != 0)
            {
                rem = nu % 10;
                num = num + rem * rem * rem;
                nu = nu / 10;
            }
            if (num == n)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }

        }
    }
}
