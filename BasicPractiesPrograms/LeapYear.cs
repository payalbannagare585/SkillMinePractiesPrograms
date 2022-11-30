using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year.");
            year=int.Parse(Console.ReadLine());

            if (year % 400== 0){
                Console.WriteLine("the year is Leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("the year is not Leap year");
            }
            else if(year%4==0)
            {
                Console.WriteLine("the year is Leap Year");
            }
            else
            {
                Console.WriteLine("The year is Not Leap year");
            }
            
        }
    }
}
