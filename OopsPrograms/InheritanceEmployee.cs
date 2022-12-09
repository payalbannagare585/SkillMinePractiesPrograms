using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class InheritanceEmployee
    {
        protected int id;
        protected string name;
        protected double basic;
        protected double da;
        protected double hra;
        protected object gross;
        protected double bs;

        public InheritanceEmployee(double basic, double da)
        {
            this.basic = basic;
            this.da = da;
        }

        public InheritanceEmployee(int id, string name, double bs)
        {
            this.id = id;
            this.name = name;
            this.bs = bs;
        }

        public InheritanceEmployee(int id, string name, double basic, double da, double hra)
        {
            this.id = id;
            this.name = name;
            this.basic = basic;
            this.da = da;
            this.hra = hra;
        }

        public virtual void CalculateSalary()
        {
            int gross = (int)(basic + hra + da);
            Console.WriteLine("gross for Parent class Employee : "+gross);
        }
          

        public class Manager : InheritanceEmployee
        {
            private double food;
            private double pf;

            public Manager(int id, string name, double da, double food) : base(id, name, da)
            {
                this.food = food;
            }
            public override void CalculateSalary()
            {
                hra = basic * 0.40;
                da = basic * 0.20;
                pf = basic * 0.12;
                gross = (basic + hra + da + food) - pf;

                Console.WriteLine("gross for Maneger child class: "+gross);
            }

            public override string ToString()
            {
                return $"Employee id {id}, emp name {name} & gross salary of manager {gross}";
            }


        }

        public class SalesManager : InheritanceEmployee
        {
            private double commition;
            private double bonus;

            public SalesManager(double commition, double bonus, double da, double hra, double basic) : base(basic, da)
            {
                this.commition = commition;
                this.bonus = bonus;
            }

            public new void CalculateSalary()//new keyword is hide the base class method
            {
                hra = basic * 0.40;
                da = basic * 0.20;
                gross = (basic + hra + da + bonus + commition);

                Console.WriteLine("gross for SalesManger child class is: " + gross);

            }

           


        }

    }

}
