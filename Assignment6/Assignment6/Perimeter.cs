using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Perimeter
    {
        //  Q1)
        enum shape{circle=0,square=1 };

       static double peri(int a, int b)
        {
            if (b == 0)
            {
                return 2 * 3.14 * a;
            }
            else
            {
                return 4 * a;
            }

        }
        static void Main(String [] args)
        {
            
            Console.WriteLine(peri(4, (int)shape.circle));
            Console.ReadLine();
            
        }
    }
}
