using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question1
            /*
            int a = 5;
            int b = 0;

            try
            {
                int c = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
            */

            //Question 2)
            /*
            int[] a = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured : "+ex.ToString());
            }
            finally
            {
                Console.WriteLine("In Finally Block");
            }
            Console.ReadLine();
            */

            //Question 3)

            /*
            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };

            try
            {
                for (int j = 0; j < 6; j++)

                    try
                    {

                        Console.WriteLine("Number: " + number[j]);
                        Console.WriteLine("Divisor: " + divisor[j]);
                        Console.WriteLine("Quotient: " + number[j] / divisor[j]);
                    }


                    catch (DivideByZeroException)
                    {

                        Console.WriteLine("Not possible to Divide by zero");
                    }


                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Index is Out of Range");
                    }
            }
            catch(IndexOutOfRangeException)
            {

                Console.WriteLine("Not possible to Divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Super class exception");
            }

           
            Console.ReadLine();
            */

            //Question 4)
            /*
            int[] a = { 8, 17, 24, 5, 25 };
            try
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine("Element at index " + j + " is : " + a[j]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            */

            //Question 5)
            /*
            int[] a = { 8, 17, 24, 5, 25 };
            try
            {
                throw new MyException("This message is from user defined exception");
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
               
            }
            Console.ReadLine();
            */
            //Question6)
            /*
            Console.WriteLine("Program 11");
            try
            {
                int a = 0;
                int b = 20;
           

                int c = b/ a;
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("Cannot divide with zero"+ e.Message );
            }
            Console.ReadLine();
            */

            //Question7)
            /*
            Console.WriteLine("Enter value of x : " );
            int x = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (x < 0)
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Number cannot be less than 0");
            }
       
            Console.ReadLine();
            */

            //Question8)
            double a = 50;

            try
            {
                object value = 12;
                string s = (string)value;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine("Error : "+ex.Message);
            }
            Console.ReadLine();
        }

        class MyException : Exception
        {
            public MyException()
            {
                Console.WriteLine("User Exception Default");
            }

            public MyException(String message) : base(message)
            {
               
            }
        }
    }
}
