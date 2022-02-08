using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            //Q3)
            DateTime dt = new DateTime(2016, 11, 7);
         
           
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
            
            Console.ReadLine();
        }
    }
}
