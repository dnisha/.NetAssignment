using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class TestDemo
    {
        static void Main(string[] args)
        {
            Rectangle1 r1 = new Rectangle1(12,4,"blue");
           
            Console.WriteLine(r1.area());
            r1.displayArea();
            Console.WriteLine(r1.getColor());
          
            Console.ReadLine();
        }
    }

    abstract class Shape
    {
        String color;
      public  void setColor(String c)
        {
            color = c;
        }
        public  String getColor()
        {
            return color;
        }
        public abstract double area();

       

    }

    class Rectangle1 : Shape
    {
        int l, w;

        public Rectangle1(int l,int b,String color)
        {
            this.setColor(color);
            this.l = l;
            this.w= b;
        }
        public override double area()
        {
            return l * w;
        }

        public void displayArea()
        {
            Console.WriteLine("Area of Rectangle : "+this.l*this.w);
        }
    }
}
