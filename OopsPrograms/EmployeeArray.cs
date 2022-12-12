using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class EmployeeArray
    {
        public int Id { get; set; }

        public string Name{ get; set; }
        public double Salary{ get; set; }

        public static void Main(string[] args)
        { 

            EmployeeArray[] empArray= new EmployeeArray[]
                {
                   new EmployeeArray{Id=101,Name="Payal",Salary=25000},
                   new EmployeeArray{Id=102,Name="Kalyani",Salary=30000},
                   new EmployeeArray{Id=103,Name="chanchal",Salary=35000},
                   new EmployeeArray{Id=104,Name="vaishnavi",Salary=21000},
                };

            foreach(EmployeeArray item in empArray)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Salary}");
            }
        }

    }
}
