using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1)
            /*
            int x =add(3, 4);
            Console.WriteLine(""x);
            Console.ReadLine();
            */

            //Q2)
            /*
            parallelogram(4, 8);
            */

            //Q4)
            /*
            fibonacci(9);
            */

            //Q6)
            /*
           int a= sumnatural(5);
            Console.Write("sum of natural number : " + a);
            Console.ReadLine();
            */

            //Q5)
            /*
            int a = 0;
            int b = 1;
            Console.Write(a + " " + b);
            fibonac2(a, b, 7 - 2);
            Console.ReadLine();
            */
            //Q7)
            Console.WriteLine("Enter a number :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(binary(n1));
            Console.ReadLine();

        }
        //Q1)
        /*
        public static int add(int a,int b)
        {
            return a + b;
        }
        */

        //Q2)
        /*
        public static void parallelogram(int a,int b)
        {
            for(int i = 1; i <= a; i++)
            {
               if(i >= 2)
                {
                    for (int j = 1; j <i; j++)
                    {
                        Console.Write(" ");
                    }
                }
                for(int j = 1; j <= b; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("\t");

            }
            Console.ReadLine();
        }
        */
        //Q3)
        /*
        public static int add(int a, int b)
        {
            return a + b;
        }
        */
        /*
        public static int subtract(int a, int b)
        {
            return a - b;
        }
        */
        /*
        public static int add(int a, int b)
        {
            return a * b;
        }
        */

        /*
        public static double add(int a, int b)
        {
            return a / b;
        }
        */

        //Q4)
        /*
        public static void fibonacci(int n)
        {
            int a = 0, b = 1,c;
            Console.Write(a+"\t");
            Console.Write(b + "\t");
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c+"\t");   
            }
            Console.ReadLine();
        }
        */
        //Q5)
        /*
        public static void fibonac2(int a, int b, int n)
        {
            if (n > 0)
            {
                int a1 = a;
                int b1 = b;
                int c = a1 + b1;
                Console.Write(" " + c);
                fibonac2(b1, c, n - 1);
            }

        }
        */

        //Q6)
        /*
        public static int sumnatural(int n)
        {

            if (n != 0)
            {
                return n+ sumnatural(n - 1);
            }


            return n ;

        }
        */

        //Q7)
        public static int binary(int n)
        {
            if (n > 0)
            {
                int a = n % 2;
                return (a + 10 * binary(n / 2));
            }
            return 0;
        }

        //Q8)
        /*
        public static void spacestring()
        {
            Console.Write("Enter a string : ");
            String a = Console.ReadLine();
            int count=0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] == ' ')
                {
                    count++;
                }

            }
            Console.Write("number of spaces : "+count);
            Console.ReadLine();
        }
        */



    }
}
