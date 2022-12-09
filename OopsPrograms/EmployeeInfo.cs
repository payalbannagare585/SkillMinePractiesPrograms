using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class EmployeeInfo
    {
        public static int empid;
        private string empname, country;
        private int salary;
        private static int count;
        public EmployeeInfo(string empname,int salary, string country = "India")
        {
            count++;
            empid = count;
            this.empname = empname;
            this.salary = salary;
            this.country = country;
        }

        public static int CountEmp()
        {
            return count;
        }

        public override string ToString()
        {
            return $"{empid} -> {empname} -> {salary}->{country}";
        }
    }

}

