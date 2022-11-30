using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class Pattern4
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 4; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
           
        }
    }
}
