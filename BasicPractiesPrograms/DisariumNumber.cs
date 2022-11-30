using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class DisariumNumber
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number to check: ");
            num = int.Parse(Console.ReadLine());

            int sum = 0, x = 0;
            int temp = num;

            int count_digits = num.ToString().Length;
            while (temp > 0)
            {
                x = temp % 10;
                sum = sum + (int)Math.Pow(x, count_digits);
                count_digits--;

                temp = temp / 10;

            }
            if (sum == num)
            {
                Console.WriteLine("Disarium Number");
            }
            else
            {
                Console.WriteLine("Not Disarium Number");
            }
        }
    }
}

