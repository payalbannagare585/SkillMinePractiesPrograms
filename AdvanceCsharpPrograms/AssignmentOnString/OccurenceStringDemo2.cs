using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms.AssignmentOnString
{
    public class OccurenceStringDemo2
    {
        string str;
        string[] str = new string[];
        str=Console.ReadLine();
        public static void Main(string[] args)
        {
            for(int i = 0; i <= str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
