using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCrudOperations.ProductCrud_App
{
    struct productstruct
    {
    
            private void Introduction()
            {
                Console.WriteLine("----------------------------------------------PRODUCT APPLICATION ----------------------------------------------------");
                Console.WriteLine("\n                                        ----------WELCOME----------                   ");
            }
            public void ShowIntroduction()
            {
                Introduction();
            }

            internal void Load()
            {
                Console.Write("Loading");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(500);
                }
            }


    }
}



