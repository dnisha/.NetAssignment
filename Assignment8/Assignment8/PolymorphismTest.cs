using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class PolymorphismTest
    {
        static void Main(String [] args)
        {
            Cube c = new Cube();
            Console.WriteLine("area of cube : "+c.area1());
            Console.WriteLine("volume of cube : "+c.volume());

            Circle c1 = new Circle();
            Console.WriteLine("area of circle : " + c1.area1());
            Console.WriteLine("volume of circle : " + c1.volume());
            Console.ReadLine();

        }

    }
    interface Shape1
    {
        double area1();
        double volume();
    }

    class Cube : Shape1
    {
        int x=10;
        public double area1()
        {
            return 6 * x *x;
        }

        public double volume()
        {
            return x * x * x;
        }
    }
    class Circle : Shape1
    {
        int r = 10;
        public double area1()
        {
            return 2 * 3.14 * r;
        }

        public double volume()
        {
            return 0;
        }
    }

}
