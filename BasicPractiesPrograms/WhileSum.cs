using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BasicPractiesPrograms
{
    internal class WhileSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 1;
            while (n <= 20)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }
                
                sum = sum + n;
                n++;
            }
            Console.WriteLine("sum of odd numbers: " + sum);



        }
    }
}
