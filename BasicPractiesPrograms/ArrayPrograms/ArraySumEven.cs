using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{

    internal class ArraySumEvenNum
    {
        int[] nums = new[] { 1, 5, 8, 9, 12, 28, 40 };
        int SumOfEven = 0;

        public void SumOfArray()
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.WriteLine(nums[i]);
                    SumOfEven = nums[i] + SumOfEven;

                }
            }

            Console.WriteLine("Sum of Even number is: " + SumOfEven);

        }
        public static void Main(string[] args)
        {
            ArraySumEvenNum se = new ArraySumEvenNum();
            se.SumOfArray();

        }


    }
}

