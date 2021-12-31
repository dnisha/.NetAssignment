using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tut2
{
    internal class Class4
    {
        static void Main(string[] args)
        {

            //Q17
            /*
            Console.WriteLine("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Squre of number : " + (a * a));
            Console.ReadLine();
            */

            //Q18
            /*
            Console.WriteLine("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Squre of number : " + (a*a*a));
            Console.ReadLine();
            */

            //Q19
            /*
            Console.WriteLine("Enter First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = b;
            b = a;
            a = c;
            Console.WriteLine("value of first number is :"+a);
            Console.WriteLine("value of second number is :" + b);
            Console.ReadLine();

            */

            //Q20
            /*
            Console.WriteLine("Enter First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
           
            Console.WriteLine("value of first number is :" + a);
            Console.WriteLine("value of second number is :" + b);
            Console.ReadLine();
            */

            //Q22
            /*

            Console.WriteLine("Enter name of user : ");
            String a = Console.ReadLine();

            Console.WriteLine("Welcome "+a+".....!!!");
            Console.ReadLine();
            */

            //Q23
            /*
            Console.WriteLine("Enter name of employee : ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter age of employee : ");
            String age = Console.ReadLine(); 
            Console.WriteLine("Enter phone number of employee : ");
            String phone = Console.ReadLine();
            Console.WriteLine("Enter email of employee : ");
            String email = Console.ReadLine();
            Console.WriteLine("Enter address of employee : ");
            String address = Console.ReadLine();
            Console.WriteLine("Details of employee : ");
            Console.WriteLine(" employee name: "+name+", employee age : "+age+", employee phone number : "+phone+", employee email :"+email+" ,employee address :"+address);

            Console.ReadLine();

            */

            //  Q21
            Console.WriteLine("Enter four digit number: ");
            int num = Convert.ToInt32( Console.ReadLine());
            int a = num % 10;
            num = num / 10;
            int b = num % 10;
            num=num / 10;
            int c = num % 10;
            num = num / 10;
            int d = num % 10;
            int sum = a + b + c + d;
            Console.WriteLine("Sum " + sum);

            //reverse
            String s = Convert.ToString(a)+ Convert.ToString(b)+ Convert.ToString(c)+ Convert.ToString(d);
            Console.WriteLine(s);


            //last digint in first
            String s2 = Convert.ToString(d)+ Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c);
            Console.WriteLine(s2);


            //exchange
            String s3 = Convert.ToString(a) + Convert.ToString(c) + Convert.ToString(b) + Convert.ToString(d);
            Console.WriteLine(s3);

            Console.ReadLine();
        }
    }
}
