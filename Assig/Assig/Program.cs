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
            /*
            Console.WriteLine("Enter a character  : ");
            String a =  Console.ReadLine();

          String u =   a.ToUpper();
            Console.WriteLine(u);
            Console.ReadLine();
            */

            //Q8
            /*
            Console.WriteLine("Enter ATM PIN  : ");
            String a = Console.ReadLine();
            if(a == "123"){
                Console.WriteLine("PIN is correct");
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
            }

            Console.ReadLine();
            */


            //Q9
            /*
            Console.WriteLine("Enter ATM PIN  : ");
            String a = Console.ReadLine();
            int amount = 5000;
            if (a == "123")
            {
                Console.WriteLine("PIN is correct");
                Console.WriteLine("Enter amount you want to withdraw : ");
                int withdraw = Convert.ToInt32( Console.ReadLine());
                amount = amount - withdraw;

                Console.WriteLine("Remaining amount : "+amount);
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
            }

            Console.ReadLine();
            */


            //Q10
            /*

            Console.WriteLine("Enter Temperature  : ");
            int t =Convert.ToInt32(  Console.ReadLine());

            if(t < 0)
            {
                Console.WriteLine("ICE");
                Console.ReadLine();
            }
            else if(t > 0 && t < 100)
            {
                Console.WriteLine("WATER");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("STEAM");
                Console.ReadLine();
            }

            */

            //Q11
            /*
            Console.WriteLine("Enter Marks of First Subject  : ");
            int m1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Marks of Second Subject  : ");
            int m2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Marks of third Subject  : ");
            int m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of fourth Subject  : ");
            int m4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of fifth Subject  : ");
            int m5 = Convert.ToInt32(Console.ReadLine());


           double percent = (m1+m2 + m3 + m4 + m5) / 5;

            if(percent > 60)
            {
                Console.WriteLine("FIRST DIVISION");
                Console.ReadLine();
            }
            else if(percent >50 && percent <59)
            {
                Console.WriteLine("SECOND DIVISION");
                Console.ReadLine();

            }
            else if(percent >40 && percent < 49)
            {
                Console.WriteLine("THIRD DIVISION");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("FAIL");
                Console.ReadLine();
            }

            */

            //Q12
            Console.WriteLine("Twinkle, twinkle, little star");
            Console.WriteLine("\t How I wonder what you are");
            Console.WriteLine("\t\t Up above the world so high");
            Console.WriteLine("\t\t Like a diamond in the sky");
            Console.WriteLine("Twinkle, twinkle, little star");
            Console.WriteLine("\t How I wonder what you are");
            Console.ReadLine();

        }
    }
}
