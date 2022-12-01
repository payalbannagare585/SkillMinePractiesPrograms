using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{
    internal class ReplaceByAlternateChar
    {
        public void ReplaceByAlternatech(char[]a) 
        {
            Console.WriteLine("After Replacing charecter by next Alternate Character..");
            for(int i=0;i<a.Length;i++) 
            {
                if (a[i] == 'Y' || a[i] == 'y' || a[i] == 'z' || a[i]=='Z')
                {
                    a[i] = (char)(a[i] - 24);
                }
                else
                {
                    a[i] = (char)(a[i] + 2);
                }
                Console.WriteLine(a[i]+" ");
            }


        }
        public static void Main(string[] args)
        {
            char[] a = { 'a', 'g', 'h', 'y', 'm', 'r' };
            ReplaceByAlternateChar ra=new ReplaceByAlternateChar();
            ra.ReplaceByAlternatech(a);
        }
    }
}
