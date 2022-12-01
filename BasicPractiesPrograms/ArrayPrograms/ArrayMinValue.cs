using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{
    internal class ArrayMinValue
    {
        public void FindMinValue()
        {
            int[] arr = { 89, 45, 8, 55, 98, 33, 65, 76, 12, 87, 56 };
            for(int i=1;i<arr.Length;i++)
            {
               Console.WriteLine(arr.Min());
                break;    
            }
        }
        public static void Main(string[] args)
        {
            ArrayMinValue min = new ArrayMinValue();
            min.FindMinValue();
        }
    }
}
