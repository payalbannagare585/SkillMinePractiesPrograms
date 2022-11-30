using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class NumberTable
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number:");
            num=int.Parse(Console.ReadLine());

            for(int i=1;i<=10;i++) 
            {
                int result = num * i;
                Console.WriteLine(result);
            }
        }
    }
}
