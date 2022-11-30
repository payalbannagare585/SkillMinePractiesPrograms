using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{
    internal class CountArrayElements
    {
        public int CounElements()
        {
            var total = 0;

           
            int[] nums = {54,96,23,32,56,98,64,95,8,6,2,8};


            total = nums.Count();
            return total;
        }
        public static void Main(string[] args)
        {
            CountArrayElements count = new CountArrayElements();
            count.CounElements();

            Console.WriteLine("Count of elements in the array is: "+count.CounElements());

        }
    }
}

