using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class Pattern6
    {
        static void Main(string[] args)
        {
            int x, y;
            int a = 4;
            for (x = 1; x <= a; x++)
            {
                for (y = a; y >= x; y--)
                {
                    Console.Write((char)(y + 64));
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
