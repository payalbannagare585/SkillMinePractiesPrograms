using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleCrudOperations
{
    internal class Admin
    { 
        public void AddAdmin() 
        {
            Console.WriteLine("\n Login As Admin Please Enter Admin Details:");

            string adminname, adminpassword=string.Empty;

            Console.WriteLine("Enter Admin name: ");
            adminname = Console.ReadLine();

            Console.WriteLine("Enter Admin Password: ");
            adminpassword = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(File.Create("C:\\thinkQuietiont Course\\1.txt")))
            {
                sw.Write(adminname);
                sw.Write(adminpassword);
                sw.Close();


            }

            Console.WriteLine("Admin Create Successfully.....");

            Console.Read();
        }
    }
    
}


           

          
   





