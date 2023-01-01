using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCrudOperations
{
    public class AccountsClass
    {
        public int n;
        public int num;
        private int accno;

        public int Useraccno
        {
            get { return accno; }
            set { accno = value; }
        }

        protected string name;
        internal int deposit;
        protected internal char type;

        private void CreateAccount()
        {
            Console.WriteLine("\n \n Enter The Account No. : ");
            Useraccno = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter The Name of Account Holder :  ");
            name = Console.ReadLine();

            Console.WriteLine("\n Enter Type of the Account(C/S) : ");
            type = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Initial Amount (Amount>=500 for Saving And Amount>=1000 for Current Account) : ");
            deposit = int.Parse(Console.ReadLine());

        } 
        public void Create_Account()
        {
            CreateAccount();
        }
        protected void ShowAccount()
        {
            Console.WriteLine("\n Account No. :{0}",Useraccno);
            Console.WriteLine("\n Account Holder Name :{0}",name);
            Console.WriteLine("\n Type of Account :{0}",type);
            Console.WriteLine("\n Balance Amount :{0}",deposit);

            Console.WriteLine("\n  Account Created Successfully....");

        }

        public void Show_Account()
        {
            ShowAccount();

        }

        internal void UpdateAccount()
        {
            Console.WriteLine("\n Account No. : {0}",accno);
            Console.WriteLine("Update Account Holder Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Update Type of Account : ");
            type = char.Parse(Console.ReadLine());

            Console.WriteLine("Update Balance Amount : ");
            deposit = int.Parse(Console.ReadLine());

        }

        public void Update_Account()
        {
            UpdateAccount();
        }

        public void AccountDeposit()
        {
            int x;
            Console.WriteLine("\n Enter the Amount you want to Deposit:  ");
            x = int.Parse(Console.ReadLine());
            deposit += x;

        }
        public void AccountWithdraw()
        {
            int x;
            Console.WriteLine("\n Enter the Amount you want to Withdraw: ");
            x = int.Parse(Console.ReadLine());
            deposit -= x;
        }

        public void AccountDetails()
        {
            Console.WriteLine("\nAccount Number: {0}",accno);
            Console.WriteLine("Account Holder Name: {0}",name);
            Console.WriteLine("Account Type is: {0}",type);
            Console.WriteLine("Account Deposite: {0}",deposit);

        }

        public int AccountNo()
        {
            return accno;
        }
        public string AccountHolderName()
        {
            return name;
        }

        public int AccountDepDetail()
        {
            return deposit;
        }

        public char AccTypeDetail()
        {
            return type;
        }
    }

}

