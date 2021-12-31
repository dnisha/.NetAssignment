using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            /*
            Console.WriteLine("Enter any number : ");
           int a=Convert.ToInt32( Console.ReadLine());
            if(a%2 == 0)
            {
                Console.WriteLine(a+" is even number ");
            }
            else
            {
                Console.WriteLine(a + " is odd number ");
            }

            Console.ReadLine();
            */

            //Q2
            /*
            Console.WriteLine("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a + " is greater than "+b);
            }
            else
            {
                Console.WriteLine(b + " is greater than "+a);
            }

            Console.ReadLine();
            */

            //Q3

            /*
            Console.WriteLine("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a>c)
            {
                Console.WriteLine(a + " is greatest number ");
            }
            else if(b >a && b>c)
            {
                Console.WriteLine(b + " is greatest number ");
            }
            else
            {
                Console.WriteLine(c + " is greatest number ");

            }

            Console.ReadLine();
            */

            //Q4

            /*
            Console.WriteLine("Enter age  : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 18)
            {
                Console.WriteLine( "Eligible for voting ");
            }
            else
            {
                Console.WriteLine(" Not Eligible for voting ");
            }

            Console.ReadLine();
            */

            //Q5
            /*
            Console.WriteLine("Enter year  : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 400 == 0)
            {
                Console.WriteLine(a+" is a leap year ");
            }
            else if(a%4 == 0)
            {
                Console.WriteLine(a + " is a leap year ");
            }
            else
            {
                Console.WriteLine(a + " is not a leap year ");
            }

            Console.ReadLine();
            */

            //Q6
            /*
            Console.WriteLine("Enter a character  : ");
            char a = Convert.ToChar(Console.ReadLine());

            if(a == 'a'||a=='e'|| a == 'i' || a == 'o' || a == 'u' || a == 'A' || a == 'E' || a == 'I' || a == 'O' || a == 'U')
            {
                Console.WriteLine(a+" is a vowel ");
            }
            else
            {
                Console.WriteLine(a + " is A Consonents  ");
            }
            Console.ReadLine();
            */

            //Q7
            Console.WriteLine("Enter a character  : ");
            int a = Convert.ToChar( Console.Read());

               

            if(a>=97 && a<= 122)
            {
              
                Console.WriteLine(a);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("else block"+a);
                Console.ReadLine();
            }

            
        }
    }
}
