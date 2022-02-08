using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class DateTest
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(17, 1, 2022);
            d1.displayDate();
            d1.setDay(11);
            d1.setYear(2021);
            d1.setMonth(2);
            d1.displayDate();
            Console.WriteLine(d1.getDay());
            Console.WriteLine(d1.getMonth());
            Console.WriteLine(d1.getYear());

            Console.ReadLine();
        }
        
       
        
    }

    class Date
    {
        public int year,day,month;

        public Date(int d,int m,int y)
        {
            day = d;
            year = y;
            month = m;
        }

        public void setDay(int d)
        {
            day = d;
        }

        public void setYear(int y)
        {
            year = y;
        }
        public void setMonth(int m)
        {
            month = m;
        }

        public int getDay()
        {
            return day;
        }

        public int getMonth()
        {
            return month;
        }

        public int getYear()
        {
            return year;
        }

        public void displayDate()
        {
            Console.WriteLine(day + "/" + month + "/" + year);
        }
    }
}
