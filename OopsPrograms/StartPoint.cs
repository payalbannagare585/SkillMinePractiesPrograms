﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OopsPrograms
{
    public class StartPoint

    {
        public static void Main(string[] args)
        {
            //BookInfo b = new BookInfo();
            //b.BookId = 101;
            //b.BookName = "Revoluation 2020";
            //b.Author = "Chetan Bhagat";
            //b.Price = 1500;
            //b.DisplayBookInfo();


            //Console.WriteLine("---------------------------------------");


            //b.BookId = 103;
            //b.BookName = "Wings of Fire";
            //b.Author = "Abdul Kalam";
            //b.Price = 2000;
            //b.DisplayBookInfo();


            //StudentResultInfo s = new StudentResultInfo("Payal Bannagre", 1041, 75, 78, 80, 79, 75);
            //s.CalculatePercentage();


            EmployeeInfo e1 = new EmployeeInfo("neha tiwari",45000);
            EmployeeInfo e2 = new EmployeeInfo("komal shah",40000); 

            // named argument
            EmployeeInfo e3 = new EmployeeInfo("vaishnavi ingle",30000);

            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);


        }
    }

}