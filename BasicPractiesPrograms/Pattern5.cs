using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class Pattern5
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 4; x >= 1; x--)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

