using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms
{
    public class ProductCollectionHW
    {
        public class ProductList
        {
            public int ProdId { get; set; }
            public string ProdName { get; set; }

            public int ProdPrice { get; set; }  
        }

        public class CategoriesList
        {
            public int CategoriesCode { get; set; } 
            public string CategorieName { get; set; }  


            public List<ProductList> products=new List<ProductList>();  
        }

        public static void Main(string[] args)
        {
            List<CategoriesList> categories = new List<CategoriesList>()
            {
                new CategoriesList
                {
                    CategoriesCode=101,
                    CategorieName="Furniture",

                    products =
                    {
                        new ProductList{ProdId=202,ProdName="Chair",ProdPrice=2000},
                        new ProductList{ProdId=203,ProdName="Table",ProdPrice=4000},
                        new ProductList{ProdId=204,ProdName="Daining Table",ProdPrice=8000},
                        new ProductList{ProdId=205,ProdName="Laptop Table",ProdPrice=1000},
                    }

                },

                new CategoriesList
                {
                    CategoriesCode=103,
                    CategorieName="Laptops",

                    products =
                    {
                        new ProductList{ProdId=103,ProdName="Dell Laptop",ProdPrice=45000},
                        new ProductList{ProdId=104,ProdName="HP Laptop",ProdPrice=50000},
                        new ProductList{ProdId=105,ProdName="Acer Laptop",ProdPrice=55000},
                        new ProductList{ProdId=106,ProdName="Lenovoe Laptop",ProdPrice=50000},
                    }
                },

                new CategoriesList
                {
                    CategoriesCode=106,
                    CategorieName="Mens Wear",

                    products =
                    {
                        new ProductList{ProdId=108,ProdName="T-Shirts",ProdPrice=5000},
                        new ProductList{ProdId=109,ProdName="Jeans",ProdPrice=1000},
                        new ProductList{ProdId=110,ProdName="Smart Watchs",ProdPrice=2000},
                    }
                },
                new CategoriesList
                {
                    CategoriesCode=122,
                    CategorieName="Womens Wear",

                    products =
                    {
                        new ProductList{ProdId=301,ProdName="Sarees",ProdPrice=1000},
                        new ProductList{ProdId=302,ProdName="T-Shirts",ProdPrice=500},
                        new ProductList{ProdId=303,ProdName="Jeans",ProdPrice=1000},
                        new ProductList{ProdId=304,ProdName="Skirt",ProdPrice=8000},
                    }
                }
            };

            foreach(CategoriesList c in categories)
            {
                Console.WriteLine("Categorie Code: "+c.CategoriesCode);
                Console.WriteLine("Categorie Name: "+c.CategorieName);


                foreach(ProductList p in c.products)
                {
                    Console.WriteLine("Product Id: " + p.ProdId);
                    Console.WriteLine("Product Name: " + p.ProdName);
                    Console.WriteLine("Product Price: "+p.ProdPrice);

                }
            }
        }
    }


}
