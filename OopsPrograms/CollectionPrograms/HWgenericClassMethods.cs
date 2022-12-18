using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.CollectionPrograms
{
    public class HWgenericClassMethods
    {
        static void Main(string[] args)
        {
            List<Product> productlist = new List<Product>();
            productlist.Add(new Product { Prodid = 102, Prodname = "Hp Laptop", Prodprice = 65000 });
            productlist.Add(new Product { Prodid = 103, Prodname = "Dell Laptop", Prodprice = 76000 });
            productlist.Add(new Product { Prodid = 104, Prodname = "Acer Laptop", Prodprice = 50000 });
            productlist.Add(new Product { Prodid = 105, Prodname = "Lenove Laptop", Prodprice = 57000 });

            foreach(Product product in productlist)
            {
                Console.WriteLine( product.Prodid+" " + product.Prodname+" "+product.Prodprice);
            }
        }
    }
}
