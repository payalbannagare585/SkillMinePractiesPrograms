using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class Vowel
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any charecter: ");
            ch=Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("charecter is vowel.");
            }
            else
            {
                Console.WriteLine("charecter is consonent.");
            }
        }
    }
}
