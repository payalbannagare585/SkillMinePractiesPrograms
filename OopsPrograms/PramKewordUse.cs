using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
   public class PramKewordUse
    {
        static void AcceptNames(params string[] names)
        {
            Console.WriteLine("Values to print " + names.Length);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        static void Main(string[] args)
        {
            AcceptNames("Payal", "vaishnavi");
            AcceptNames("payal", "vaishnavi", "kalyani");
            AcceptNames("payal", "vaishnavi", "kalyani", "rolly");

        }
    }

}

