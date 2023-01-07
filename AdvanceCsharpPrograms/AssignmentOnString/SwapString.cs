using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms.AssignmentOnString
{
    internal class SwapString
    {
        public static void Main(String[] args)
        {
     
            String a = "Hello";
            String b = "Payal";

        
            Console.WriteLine("Strings before swap: a =" +
                              " " + a + " and b = " + b);

      
            a = a + b;

      
            b = a.Substring(0, a.Length - b.Length);

          
            a = a.Substring(b.Length);

     
            Console.WriteLine("Strings after swap: a =" +
                              " " + a + " and b = " + b);
        }
    }
}

