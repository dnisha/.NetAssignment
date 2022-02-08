using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program2
    {
        static void Main(String [] args)
        {
            //Q2)
            String dt = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt");
            String dt1 = DateTime.Now.ToString("MM/dd/yyyy");
            String dt2 = DateTime.Now.ToString("HH:mm:ss");
            String dt3 = DateTime.Now.ToString("MM/dd/yyyy");

            Console.WriteLine("Complete date : "+dt);
            Console.WriteLine("Short date : "+dt1);
            Console.WriteLine("24 hour date format : " + dt2);
            Console.WriteLine(dt3);
            Console.ReadLine();

        }
    }
}
