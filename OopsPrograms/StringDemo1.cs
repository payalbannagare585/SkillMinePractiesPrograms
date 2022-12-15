using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OopsPrograms
{
    public class StringDemo1
    {
        int sum;
        int total = 0;
        private static object str;
        int average;
    
        static int FindSum(string str)
        {
            int temp = 0;

            int sum = 0;


            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (char.IsDigit(ch))
                {
                    //temp += ch;
                    sum += int.Parse(ch + "");
                    //object value = Count++;


                }



            }
            return sum;
           
                

        }

           

            public static void Main(string[] args)
            {
                string str = "payal123";

                Console.WriteLine(FindSum(str));
            

            }




        }
    }
