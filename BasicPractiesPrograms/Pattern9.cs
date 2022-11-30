using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms
{
    internal class Pattern9
    {
        static void Main(string[] args)
        {
            
            int length = 4, width = 5;
            Console.Write(" ");

            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if (i == 1 || i == width || j == 1 || j == length)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n ");
            }
        }
    }
}
