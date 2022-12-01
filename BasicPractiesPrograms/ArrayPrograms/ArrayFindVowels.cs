using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.ArrayPrograms
{
    internal class ArrayFindVowels
    {
        public void FindVowels()
        {
            char[] arr= { 'd', 'i', 'j', 'k', 'e', 'h', 'a', 't', 'n', 'm', 'u' };

            for (int i = 0; i < arr.Length;i++)
            {
                if (arr[i] == 'a' || arr[i] == 'i' || arr[i] == 'e' || arr[i] == 'o' || arr[i] == 'u')
                {
                    Console.WriteLine(arr[i]);
                }

            }
        }
        public static void Main(string[] args)
        {
            ArrayFindVowels vowel=new ArrayFindVowels();
            vowel.FindVowels();

        }
    }
}
