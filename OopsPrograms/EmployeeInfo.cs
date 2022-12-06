using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class EmployeeInfo
    {
        private int empid;
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

        public override string ToString()
        {
            return $"{empid} -> {empname} -> {salary}->{country}";
        }
    }

}

