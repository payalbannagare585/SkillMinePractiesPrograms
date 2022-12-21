using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms
{
    public class ShopAppDetails
    {

            public class ProductListDemo
            {
                public int ProdId { get; set; }
                public string ProdName { get; set; }

                public int ProdPrice { get; set; }
            }

            public class CategoriesList
            {
                public int CategoryCode { get; set; }
                public string CategoryName { get; set; }


                public List<ProductListDemo> productsli = new List<ProductListDemo>();
            }

            public static void Main(string[] args)
           {
                List<CategoriesList> categories = new List<CategoriesList>()
                {
                new CategoriesList
                {
                    CategoryCode=101,
                    CategoryName="Furniture",

                    productsli =
                    {
                        new ProductListDemo{ProdId=202,ProdName="Chair",ProdPrice=2000},
                        new ProductListDemo{ProdId=203,ProdName="Table",ProdPrice=4000},
                        new ProductListDemo{ProdId=204,ProdName="Daining Table",ProdPrice=8000},
                        new ProductListDemo{ProdId=205,ProdName="Laptop Table",ProdPrice=1000},
                    }

                },

                new CategoriesList
                {
                    CategoryCode=103,
                    CategoryName="Laptops",

                    productsli =
                    {
                        new ProductListDemo{ProdId=103,ProdName="Dell Laptop",ProdPrice=45000},
                        new ProductListDemo{ProdId=104,ProdName="HP Laptop",ProdPrice=50000},
                        new ProductListDemo{ProdId=105,ProdName="Acer Laptop",ProdPrice=55000},
                        new ProductListDemo{ProdId=106,ProdName="Lenovoe Laptop",ProdPrice=50000},
                    }
                },

                new CategoriesList
                {
                    CategoryCode=106,
                    CategoryName="Men's Wear",

                    productsli =
                    {
                        new ProductListDemo{ProdId=108,ProdName="T-Shirts",ProdPrice=5000},
                        new ProductListDemo{ProdId=109,ProdName="Jeans",ProdPrice=1000},
                        new ProductListDemo{ProdId=110,ProdName="Smart Watchs",ProdPrice=2000},
                    }
                },
                new CategoriesList
                {
                    CategoryCode=122,
                    CategoryName="Women's Wear",

                    productsli =
                    {
                        new ProductListDemo{ProdId=301,ProdName="Sarees",ProdPrice=1000},
                        new ProductListDemo{ProdId=302,ProdName="T-Shirts",ProdPrice=500},
                        new ProductListDemo{ProdId=303,ProdName="Jeans",ProdPrice=1000},
                        new ProductListDemo{ProdId=304,ProdName="Skirt",ProdPrice=8000},
                    }
                }
            };

                foreach (CategoriesList c in categories)
                {
                    Console.WriteLine("Category Code: " + c.CategoryCode);
                    Console.WriteLine("Category Name: " + c.CategoryName);

                    Console.WriteLine("\n");

                    foreach (ProductListDemo p in c.productsli)
                    {
                        Console.WriteLine("   Product Id: " + p.ProdId);
                        Console.WriteLine("   Product Name: " + p.ProdName);
                        Console.WriteLine("   Product Price: " + p.ProdPrice);
                        Console.WriteLine("\n");

                    }
                }
            }
    }


}



