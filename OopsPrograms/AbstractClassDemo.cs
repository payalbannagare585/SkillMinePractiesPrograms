using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    abstract public class AbstractClassDemo
    {
        protected double pai;
        protected int r;
        protected int l;
        protected int w;
        protected int area;

       abstract public void Area();
    }


    public class Circle:AbstractClassDemo
    {
    
        public Circle(int r,double pai)
        {
            this.r = r;
            this.pai = (double)pai;
         
        }
        public  override void Area()
        {
            area = (int)((double)pai * r * r);

            Console.WriteLine("Area of Circle is: "+area);
        }
    }

    public class Rectangle:AbstractClassDemo
    {
       public Rectangle(int l,int w)
        {
            this.l = l;
            this.w = w;
        }
        public  override void Area()
        {
            area = l * w;

            Console.WriteLine("Area of Rectangle: "+area);

        }
    }
}
