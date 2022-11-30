using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class Factor
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter the Number: ");
            n=int.Parse(Console.ReadLine());

            Console.WriteLine("Factors: ");
            int sum = 0;
            for(i=1;i<=n;i++)
            {
                if (n % i == 0)
                {
                     sum = sum + i;

               
                }
                Console.WriteLine(sum);
            }
            

       
        }
    }
}
