﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
    internal class SwappingNumber
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Enter value of a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value of b: ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("after swapping value of a is: " + a);
            Console.WriteLine("after swapping value of b is: " + b);

        }
    }
}
