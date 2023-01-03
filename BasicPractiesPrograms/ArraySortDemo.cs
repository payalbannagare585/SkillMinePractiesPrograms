using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms
{
    internal class ArraySortDemo
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] {25,12,94,35,48,75,35,62,46,8};

           Array.Sort<int>(arr,2,3);
            Console.WriteLine(string.Join(" ",arr));


        }
    }
}
