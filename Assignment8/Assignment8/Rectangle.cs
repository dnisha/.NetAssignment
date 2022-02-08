using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Rectangle
    {
        public int length;
        public int width;

        public Rectangle()
        {
            length = 12;
            width = 4;

        }

        public Rectangle(int l)
        {
            length = l;
            width = 4;
        }

        public Rectangle(int l, int b)
        {
            length = l;
            width = b;
        }

        public void show()
        {
            Console.WriteLine("Length : " + this.length + " Breadth : " + this.width);
        }
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();
            Rectangle rectangle1 = new Rectangle(24);
            Rectangle rectangle2 = new Rectangle(10,3);
            rectangle.show();
            rectangle1.show();
            rectangle2.show();
            Console.ReadLine();
        }
    }
}
