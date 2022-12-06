using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.Oops_Programs
{
    internal class Account
    {
        int accountNo;
        string accountType;
        string coustName;
        int Balance;


        public int AccountNo
        {
            set {accountNo=value; } 
            get {return accountNo;} 
        }

        public string AccountType
        {
            set { accountType=value; }
            get { return accountType;}
        }
        public string CoustName
        {
            set {coustName=value;}
            get { return coustName;}

        }
    }
}
