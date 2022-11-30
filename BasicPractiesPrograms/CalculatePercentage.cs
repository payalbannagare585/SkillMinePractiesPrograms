using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class CalculatePercentage
    {
        static void Main(string[] args)
        {
            int maths, physics, chemistry, biology, cs;

            Console.WriteLine("Enter the Marks of Maths subject: ");
            maths = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Marks of physics subject: ");
            physics= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Marks of chemistry subject: ");
            chemistry= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Marks of biology subject: ");
            biology=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Marks of cs subject: ");
            cs = int.Parse(Console.ReadLine());

         

            decimal percentage = ((maths + physics + chemistry + biology + cs) * 100) / 500;

            Console.WriteLine(percentage);

            if(percentage > 70) 
            {
                Console.WriteLine("Result is Distinction. ");
            }
            else if(percentage>60-70)
            {
                Console.WriteLine("Result is 1st class.");
            }
            else if(percentage>50-60)
            {
                Console.WriteLine("Result is 2nd class.");
            }
            else if(percentage>30-50)
            {
                Console.WriteLine("Result is Pass.");

            }
            else
            {
                Console.WriteLine("Result is fail.");
            }


            
        }
    }
 }

