using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class BookInfo
    {
      
        private string bookName;
        private string author;
        private int price;

     

        public string BookName
        {
            set { bookName = value; }
            get { return bookName; }
        }

        public string Author
        {
            set { author = value; }
            get { return author; }
        }

        public int Price
        {
            set { price = value; }
            get { return price; }

        }


        public void DisplayBookInfo()
        {
           
            Console.WriteLine($"Book Name is: {bookName}");
            Console.WriteLine($"Book autor name is: {author}");
            Console.WriteLine($"Book Price is: {price}");
          
        }

    
    }




}