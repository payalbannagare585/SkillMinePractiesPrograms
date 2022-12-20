using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms
{
    internal class FindSumA
    {
        int j;
        public void FindPair(int n, int[]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                if ((a[i] + a[j]) == n)
                {
                    Console.WriteLine("(" + a[i]+")");  
                }
            }
        }
        public static void Main(string[] args)
        {
            int n = 7;
            int[]a= new int[] { 4, 5, 7, 1, 2, 3, 0 };
            FindSumA p = new FindSumA();
            p.FindPair(n, a);

        }
    }
}
