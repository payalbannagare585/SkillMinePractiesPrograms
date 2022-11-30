using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class PatternDemo1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
                
            }
        }
    }
}
