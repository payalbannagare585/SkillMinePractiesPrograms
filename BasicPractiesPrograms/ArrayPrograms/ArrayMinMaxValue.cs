using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{
    internal class ArrayMinMaxValue
    {
        
            public void FindMinMax()
            {
                char[] arr = { 's', 'e', 'u', 'z', 'd', 'j', 'k' };
                for (int i = 1; i < arr.Length; i++)
                {
                    Console.WriteLine(arr.Min());
                    Console.WriteLine(arr.Max());
                }
            }

            public static void Main(string[] args)
            {
            ArrayMinMaxValue minmax = new ArrayMinMaxValue();
                minmax.FindMinMax();
            }
        }

    }


