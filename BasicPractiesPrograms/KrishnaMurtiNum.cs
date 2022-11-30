using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class KrishnaMurtiNum
    {
        static void Main(String[]args)
        {
            long fact;
            int Num, tempNum, rem, Sum = 0, i;

            Console.WriteLine("Enter Number to Check for Krishnamurthy Number: ");
            Num=int.Parse(Console.ReadLine());

            for (tempNum = Num; tempNum > 0; tempNum = tempNum / 10)
            {
                fact = 1;

                rem = tempNum % 10;

                for (i = 1; i <= rem; i++)
                {
                    fact = fact * i;
                }

                Sum = (int)(Sum + fact);
            }

            if (Num == Sum)
                Console.WriteLine("given Number is a Krishnamurthy Number.\n", Num);
            else
                Console.WriteLine("given Number is not a Krishnamurthy Number.\n", Num);
        }
    }
}
