using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1)
            /*
            int sum = 0;
            for(int i = 1; i <= 20; i++)
            {
                if(i%2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of odd numbers : "+sum);
            Console.ReadLine();
            */

            //Q2)
            /*
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of even numbers : " + sum);
            Console.ReadLine();

            */

            //Q3)

            /*
            int sum = 0;
            for (int i = 1; i <= 200; i++)
            {
                if (i>100 && i<200)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of odd numbers : " + sum);
            Console.ReadLine();
            */

            //Q4)
            /*
            Console.WriteLine("Enter a number : ");
           int num= Convert.ToInt32( Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num+" * "+i+" = "+num*i);
            }
            Console.ReadLine();
            */

            //5)
            /*
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if(i%2 == 0)
                {
                 sum = sum +(i * i) ;
                }
            }
            Console.WriteLine("sum of first 10 even natural : " + sum);
            Console.ReadLine();
            */

            //Q6)
            /*
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + (i * i*i);
                }
            }
            Console.WriteLine("sum of first 10 even natural : " + sum);
            Console.ReadLine();
            */

            //Q7)
            /*
            double sum = 0;
            for (int i = 1; i <= 9; i=i+3)
            {
                sum = sum + (double)1 / i;
               
            }
            Console.WriteLine("sum  : " + sum);
            Console.ReadLine();
            */

            //Q8)
            /*
          
            for (int i = 65; i <= 90;i++)
            {
                Console.WriteLine("Ascii character of "+i+" : " + Convert.ToChar(i));
            }
                Console.ReadLine();
            */

            //Q9)
            /*
            for (int i = 48; i <= 57; i++)
            {
                Console.WriteLine("Ascii character of " + i + " : " + Convert.ToChar(i));
            }
            Console.ReadLine();
            */

            //Q10

            for (int i = 97; i <= 122; i++)
            {
                Console.WriteLine("Ascii character of " + i + " : " + Convert.ToChar(i));
            }
            Console.ReadLine();
        }
    }
}
