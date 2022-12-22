//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AdvanceCsharpPrograms
//{
//    internal class BankApp
//    {

//        public class Customers
//        {
//            public int CustAccNo { get; set; }
//            public string CustName { get; set; }

//            //public string LoanType { get; set; }

//            public List<LoanType> loans = new List<LoanType>();
//        }
//        public class AccountType
//        {
//            public string AccoType { get; set; }
           


//            public List<Customers> customer = new List<Customers>();
//        }
//        public class LoanType
//        {
//            public string Loans { get; set; }
//        }
   
//        static void Main(string[] args)
//        {
//            List<AccountType> accounttypeList = new List<AccountType>()
//            {
//                new AccountType
//                {
//                    AccoType="Saving",
                    
//                    customer={
//                        new Customers{CustAccNo=1012,CustName="User1",LoanType="Home Loan"},
//                        new Customers{CustAccNo=2518,CustName="User2",LoanType="Goald Loan"},
//                        new Customers{CustAccNo=8524,CustName="User10", LoanType = "Home Loan"}
//                    }
//                },
//                new AccountType
//                {
//                    AccoType="Current",
                    
//                    customer={
//                        new Customers{CustAccNo=3155,CustName="User3",
                        
//                        loans={

//                            new LoanType{Loans="Home Loan"},
//                            new LoanType{Loans="Car Loan"},

//                        },

//                    //         new Customers{CustAccNo=4455,CustName="User4",
//                    //    loans={

//                    //        new LoanType{Loans="Personal Loan"},
//                    //        new LoanType{Loans="car Loan"},
//                    //    },
//                    //    new Customers{CustAccNo=5964,CustName="User5",
//                    //    loans={
//                    //            new LoanType={Loans="Education Loan"},
//                       },
//                    }
//                },

//            };

//            foreach (AccountType at in accounttypeList)
//            {
//                Console.WriteLine(at.AccoType);
//                Console.WriteLine("-------------------------------------------");
            
//                foreach (Customers c in at.customer)
//                {
//                    Console.WriteLine(" "+"Account No: "+ c.CustAccNo+"     "+"Customer Name: " + c.CustName);
//                    foreach(LoanType l in c.loans)
//                    {
//                        Console.WriteLine(l.Loans);
//                    }
                    
//                }
//            }


//        }
//    } 

//} 

        
