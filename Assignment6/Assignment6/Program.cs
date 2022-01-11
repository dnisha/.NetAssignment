using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    struct employee
    {
        public String name;
        public int day,month ,year;
    }
    internal class Program
    {
        static void Main(string[] args)
            //Q6)
        {
            Console.WriteLine("Enter number of details of Employee you want to enter :");
            int no = Convert.ToInt32(Console.ReadLine());
            employee [] e1 = new employee [no] ;
            
            for (int i = 0; i<e1.Length;i++)
            {
                Console.WriteLine("Enter name of employee {0} : ",i+1);
                e1[i].name = Console.ReadLine();
                Console.WriteLine("Enter birth day : ");
                e1[i].day = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine("Enter month of birth : ");
                e1[i].month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter year of birth : ");
                e1[i].year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("****************************** ");

            }

            for (int i = 0; i < e1.Length; i++)
            {
                Console.WriteLine("Employee name : "+e1[i].name);
                Console.WriteLine("Employee birth day : "+e1[i].day);
                Console.WriteLine("Employee month of birth : " + e1[i].month);
                Console.WriteLine("Employee year of birth : " + e1[i].year);
                Console.WriteLine("****************************** ");

            }
            Console.ReadLine();
        }
    }
}
