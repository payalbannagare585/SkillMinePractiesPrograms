using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class StringMethodsUse
    {
        static void Main(string[] args)
        {
            string str1 = "  Hello to all  ";
            Console.WriteLine(str1.Length);
            string str2 = "welcome to C#";
            //str1.Concat(str2);
            string str = String.Concat(str1, str2);
            Console.WriteLine(str);
            Console.WriteLine(str2);
            bool result = str1.StartsWith("Hello");
            Console.WriteLine(result);
            bool res = str1.EndsWith("everyone");
            Console.WriteLine("--------------------------------------------------");

            bool r = str1.Contains("to");
            Console.WriteLine(r);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());

            char[] ch = str1.ToCharArray();
            foreach (var item in ch)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------");
             string s=str1.Trim();
            Console.WriteLine(s);

            string sl=str1.TrimEnd();
            Console.WriteLine(sl);

            string sr=str1.TrimStart();
            Console.WriteLine(sr);

       
                string str8 = "Test";
                string str9 = "TEst";
                int a = String.Compare(str8, str9);
                Console.WriteLine(a);// -1  0  1

            // it will compare using ASCII value
            // a- 97 b-98 c-99 d-100 e-101   A- 65
            // e- 101                       E- 69

            //  69-101  --> - value

            string str10 = null;
            string str20 = "TEst";
            int b = String.Compare(str10, str20);
            Console.WriteLine(a);// -1  0  1

            bool res1 = str1.Equals(str20);
            Console.WriteLine(res1);

            bool r1 = String.IsNullOrEmpty(str10);
            Console.WriteLine(r1);



            string str11 = "test";
            string str21 = str11;
            char[] ch1 = { 't', 'e', 's', 't' };

            //  string str3 = new string(ch);
            object str3 = new String(ch1);
            Console.WriteLine(str3);
            bool res3 = str1.Equals(str3);// focus on content
            Console.WriteLine(res);

            if (str11 == str3) // focus on data type
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

    }




}

