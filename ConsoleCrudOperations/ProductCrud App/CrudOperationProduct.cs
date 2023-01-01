using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCrudOperations.ProductCrud_App
{
    public class CrudOperationProduct
    {
        private List<Product> productList = null;
        internal int num;
        internal readonly int n;

        public CrudOperationProduct()
        {
            productList = new List<Product>();
        }

        public void AddProduct(Product product)

        {
            Console.WriteLine("\n Enter the Product Id: ");
            product.ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product Name: ");
            product.ProductName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Product Price: ");
            product.ProductPrice = Convert.ToInt32(Console.ReadLine());
            productList.Add(product);

        }

        public void Add_Product()
        {
           AddProduct(new Product());
        }

        public void UpdateProduct(Product product)
        {

            foreach (Product item in productList)
            {
                Product p = new Product();
                Console.WriteLine($"Enter Product Id to Update: ");
               

                p.ProductId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter new Product Name: ");
                p.ProductName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter new Product Price: ");
                p.ProductPrice = Convert.ToInt32(Console.ReadLine());





               
            }
        
            foreach (Product item in productList)
            {
                if (item.ProductId == product.ProductId)
                {
                    item.ProductName = product.ProductName;
                    item.ProductPrice = product.ProductPrice;
                    break;
                }
            }
        }
        public void Update_Product()
        {
            UpdateProduct(new Product());   
        }


        public void RemoveProduct(int proid)
        {
            
            foreach (Product item in productList)
            {
                if (item.ProductId == proid)
                {
                    productList.Remove(item);
                    break;
                }
            }
        }

    
        public List<Product> List()
        {
            foreach (Product items1 in productList)
            {
                Console.WriteLine($"\n Product Id: {items1.ProductId}");
                Console.WriteLine($"Product Name: {items1.ProductName}");
                Console.WriteLine($"Product Price: {items1.ProductPrice}");
            }
            return productList;
        }

    
    }
}



