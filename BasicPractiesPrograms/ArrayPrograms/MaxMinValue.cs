using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{
    internal class MinMaxValue
    {
        
            public void FindMinMax()
            {
                char[] arr = { 's', 'e', 'u', 'z', 'd', 'j', 'k' };
                for (int i = 1; i < arr.Length; i++)
                {
                    Console.WriteLine("Minimum value is: "+arr.Min());
                    Console.WriteLine("Maximun value is: "+arr.Max());
                break;
                }
            }

            public static void Main(string[] args)
            {
            MinMaxValue minmax = new MinMaxValue();
                minmax.FindMinMax();
            }
        }

    }


