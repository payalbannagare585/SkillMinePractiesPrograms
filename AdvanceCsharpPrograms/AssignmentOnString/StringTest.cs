using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms.AssignmentOnString
{
    //mom
    internal class StringTest
    {
        public static string str1;
        public static void Main(string[] args)
        { 
            str1=Console.ReadLine();
            char[] chars=str1.ToCharArray();

            char[] str2= new char[chars.Length];
            

            for(int i=chars.Length-1;i>=0;i--)
            {
                str2[i]= chars[i];
            }
            string str3 = string.Join("", str2);
            if (str1 ==str3 )
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
           


       
   

       



  

       


            }

    }
}
