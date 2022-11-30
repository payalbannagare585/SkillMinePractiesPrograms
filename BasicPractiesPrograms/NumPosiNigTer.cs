using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class NumPosiNigTer
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            string Result = (num > 0) ?"Number is Positive." : "Number is Negative";

            Console.WriteLine(Result);
        }
    }
}
