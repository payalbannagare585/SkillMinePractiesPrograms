using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{
    internal class SortingArrayDemo
    {
        public int[] Mysort(int[]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            return a;

        }
        static void Main(string[]args)
        {
            int[] arr = { 8, 3, 5, 1, 9 };
            Console.WriteLine(string.Join(" ", arr));
            SortingArrayDemo s = new SortingArrayDemo();

            Console.WriteLine("....." + string.Join(" ", s.Mysort(arr)));

        }

       
    }
}
