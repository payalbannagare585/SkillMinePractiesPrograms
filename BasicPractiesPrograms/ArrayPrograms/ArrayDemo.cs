using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{
    internal class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 6, 23, 96, 6 };//declaration and value assign at a time
            int[] myarr = new int[5];//declare array

            //value assign value to array element
            myarr[0] = 52;
            myarr[1] = 58;
            myarr[2] = 95;
            myarr[3] = 41;
            myarr[4] = 35;
            
            foreach(int itr in arr)
            {
                Console.WriteLine(itr);
            }
        }
    }
}
