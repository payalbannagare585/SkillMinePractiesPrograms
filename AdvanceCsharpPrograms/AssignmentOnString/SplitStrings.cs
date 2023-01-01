using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms.AssignmentOnString
{
    //1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
    public class SplitStrings
    {
        public static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Enter the string which you want to split: ");
            str = Console.ReadLine();
            
                string[] res = str.Split(' ');
            
            foreach(string result in res)
            {
                Console.WriteLine(result);
            }
        }
    }
}
