using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class BreakDemo2
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 20)
            {
                sum = sum + i;
                Console.WriteLine(sum);

                i++;
                if (sum >= 10)
                {
                    break;
                }
          
            }
          
        }
    }
}
