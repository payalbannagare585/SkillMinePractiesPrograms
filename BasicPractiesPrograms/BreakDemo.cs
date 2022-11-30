using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class BreakDemo
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=50)
            {
                if (i%5==0)
                {

                    break;
                }
                
                Console.WriteLine(i);
                i++;
            }
            
        }
    }
}
