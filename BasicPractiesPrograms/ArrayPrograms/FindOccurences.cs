using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{
    internal class FindOccurences
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 2, 7, 7, 2, 1 };

            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;

                for(int k=i-1;k>=0;k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;

                    }
                }
                if(isvisited==false)
                {
                    for(int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+" "+count);
                }
            }
        }
    }
}
