using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class OddFor
    {
        static void Main(string[] args)
        {
            //for (int i = 120; i>=81; i--)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            for(int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
       
    }
}
