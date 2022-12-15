using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public  class StringBuilderUse
    {
        private static object price;

        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello to all");
            Console.WriteLine(sb);
            sb.Append(" Welcome in C# batch");
            Console.WriteLine(sb);


            sb.Replace("all", "everyone");
            Console.WriteLine(sb);

            //sb.AppendFormat("price is {0:c"),price);
        }
    }
}
