using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class Pattern3
    {

        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 4; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    if (y == 1 || y == x || x == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
