using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCrudOperations.ProductCrud_App
{
    internal class StartProduct
    {
        static void Main(string[] args)
        {
            productstruct show = new productstruct();

            CrudOperationProduct product= new CrudOperationProduct();

            show.Load();
            Console.Clear();

            show.ShowIntroduction();

            do
            {
                Console.WriteLine("\n          ...........................................MENU........................................................");

                Console.WriteLine("\n 1. ADD PRODUCT");
                Console.WriteLine("\n 2. UPDATE PRODUCT");
                Console.WriteLine("\n 3. PRODUCT DETAILS");
                Console.WriteLine("\n 4. REMOVE PRODUCT");
                Console.WriteLine("\n 5. EXIT");



                Console.WriteLine("\n \n Select Your Option From (1-5)");

                int n;
                n = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (n)
                {

                    case 1:
                        {
                            Console.Clear();
                            show.Load();
                            product.Add_Product();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            show.Load();

                            Console.WriteLine("\n \n \t Enter The Product Id : ");

                            product.num = int.Parse(Console.ReadLine());
                 
                            product.Update_Product();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            show.Load();
                            product.List();
                            break;
                        }
                }

            } while (product.n!=5);

        }
    }
}

          

           
    
