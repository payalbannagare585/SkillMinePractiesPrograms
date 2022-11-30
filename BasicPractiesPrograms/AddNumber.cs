using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class AddNumber
    {
        static void Main(string[] args)
        {
            int num = 0;
            for(int i=1;i<=10;i++)
            {
                num = num + i;

                Console.WriteLine(num);
            }
        }
    }
}
