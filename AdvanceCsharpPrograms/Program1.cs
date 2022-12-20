using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms
{
    internal class Program1
    {
   

        public static void Main()
        {
            string str1 = "Silent";
            string str2 = "Listen";


            str1 = str1.ToLower();
            str2 = str2.ToLower();


            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Both the strings are not anagram");
            }

            else
            {
                char[] string1 = str1.ToCharArray();
                char[] string2 = str2.ToCharArray();


                Array.Sort(string1);
                Array.Sort(string2);

                if (string1.ToString().Equals(string2.ToString()))
                {
                    Console.WriteLine($"{str1} and {str2} strings are anagram");
                }
                else
                {
                    Console.WriteLine($"{str1} and {str2} strings are not anagram");
                }
            }
        }


    }

}

