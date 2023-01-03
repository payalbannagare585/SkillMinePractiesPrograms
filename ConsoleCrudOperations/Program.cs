using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleCrudOperations
{
    internal class Program:AccountsClass
    {
        public int a;
        public int n;

        static void Main(string[] args)
        {
            Welcome show = new Welcome();

            AccountsClass bank = new AccountsClass();

            Admin admin = new Admin();

            show.Load();
            Console.Clear();

            show.ShowIntroduction();

            admin.AddAdmin();
            Console.Clear();

         
                        string adminname, adminpassword, adminname1, adminpassword1 = string.Empty;

                        Console.WriteLine("Enter a Admin Name: ");
                        adminname = Console.ReadLine();

                        Console.WriteLine("Enter a Admin Password: ");
                        adminpassword = Console.ReadLine();

                        using (StreamReader sr = new StreamReader(File.Open("C:\\thinkQuietiont Course\\1.txt", FileMode.Open)))
                        {
                            adminname1 = sr.ReadLine();
                            adminpassword1 = sr.ReadLine();
                            sr.Close();

                            if (adminname == adminname1 && adminpassword == adminpassword1)
                            {
                                Console.WriteLine("Admin Login Successfully......");
                            }
                        }

                        Console.Clear();
                        

                    


                        do
                        {
                            Console.WriteLine("\n .......................................................MENU.........................................................");

                            Console.WriteLine("\n 1. NEW ACCOUNT");
                            Console.WriteLine("\n 2. DEPOSIT AMOUNT");
                            Console.WriteLine("\n 3. WITHDRAWA AMOUNT");
                            Console.WriteLine("\n 4. BALANCE DETAILS");
                            Console.WriteLine("\n 5. UPDATE ACCOUNT");
                            Console.WriteLine("\n 6. EXIT");

                            Console.WriteLine("\n \n Select Your Option From (1-6)");

                            int n;
                            n = int.Parse(Console.ReadLine());
                            Console.Clear();


                            switch (n)
                            {

                                case 1:
                                    {
                                        Console.Clear();
                                        show.Load();
                                        bank.Create_Account();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Clear();
                                        show.Load();
                                        bank.AccountDeposit();
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        show.Load();
                                        bank.AccountWithdraw();
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Clear();
                                        show.Load();
                                        bank.AccountDetails();
                                        break;
                                    }

                                case 5:
                                    {
                                        Console.Clear();
                                        show.Load();
                                        Console.WriteLine("\n \n \t Enter The Account NO. : ");

                                        bank.num = int.Parse(Console.ReadLine());
                                        bank.UpdateAccount();
                                        break;

                                    }

                            }
                        } while (bank.n != 5);
                    
            
        }
    }
}
