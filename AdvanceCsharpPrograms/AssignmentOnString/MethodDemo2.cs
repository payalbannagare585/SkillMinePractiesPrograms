using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms.AssignmentOnString
{
    internal class MethodDemo2
    {
        
        public static int Add(int a,int b)
        {
            int add = a + b;

            return add;
        }

        public static int Add(int a,int b,int c)
        {
            int add= a + b + c;

            return add;
        }

        
    }

    class CallMethod
    {
        static void Main(string[] args)
        {
           
     

            Console.WriteLine(MethodDemo2.Add(43, 87));
            Console.WriteLine(MethodDemo2.Add(52, 85, 65));

            

        }
    }
}
