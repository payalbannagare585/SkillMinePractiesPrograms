using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMinePractiesPrograms.Oops_Programs
{
    public class Car

    {
        public int CarModelNum;
        public string CarName;
        public int CarPrice;
        public string CarColour;
        public void AcceptDetails(int CarModelNum,string CarName,int CarPrice,string CarColour)
        {
            this.CarModelNum=CarModelNum;
            this.CarName=CarName;
            this.CarPrice=CarPrice;
            this.CarColour=CarColour;
        }

        public void Display()
        {
            Console.WriteLine("car Model number is: "+CarModelNum);
            Console.WriteLine("car Name is: " + CarName);
            Console.WriteLine("car Price is: " + CarPrice);
            Console.WriteLine("car Colour is: " + CarColour);

            Console.WriteLine("-----------------------------------------------------");
        }

        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.AcceptDetails(2016, "BMW", 690000, "Black");
            car1.Display();

            Car car2= new Car();
            car2.AcceptDetails(2014, "Ford Raptor", 950000, "White");
            car2.Display();

            Car car3= new Car();
            car3.AcceptDetails(2011, "Audi", 68000, "Red");
            car3.Display();
        }
    }
}
