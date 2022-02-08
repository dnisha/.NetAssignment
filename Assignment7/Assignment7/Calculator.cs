using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Calculator
    {
        static void Main(String [] args)
        {
            Calculator c = new Calculator();
            
            Console.WriteLine("Press 1 for Addition :");
            Console.WriteLine("Press 2 for Subtraction :");
            Console.WriteLine("Press 3 for Multiplication :");
            Console.WriteLine("Press 4 for Division :");
            Console.WriteLine("Press 5 for Modulus :");
            Console.WriteLine("Press 6 for Factorial :");
            Console.WriteLine("Press 7 for square :");
            Console.WriteLine("Press 8 for cube :");
            Console.WriteLine("Press 9 for power :");
            Console.WriteLine("Press 10 for exponential :");
            Console.WriteLine("What do you want to perform :");
            int o= Convert.ToInt32(Console.ReadLine());
            switch (o)
            {
                    case 1:c.addition();
                    break;
                    case 2:c.subtraction();
                    break;
                case 3:c.multiplication();
                    break;
                case 4:c.division();
                    break;
                case 5:c.modulus();
                    break;
                case 6:c.factorial();
                    break;
                case 7:c.square();
                    break;
                case 8:c.cube();
                    break;
                case 9:c.powern();
                    break;
                case 10:c.exp();
                    break;

            }
                

         
            Console.ReadLine();

        }

        public void addition()
        {
            Console.WriteLine("Enter first Number : ");
           int a=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of {0} and {1} is : "+(a+b),a,b);
        }

        public void subtraction()
        {
            Console.WriteLine("Enter first Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subtraction of {0} and {1} is : " + (a - b), a, b);
        }
        public void multiplication()
        {
            Console.WriteLine("Enter first Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication of {0} and {1} is : " + (a * b), a, b);
        }
        public void division()
        {
            Console.WriteLine("Enter first Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subtraction of {0} and {1} is : " + (a / b), a, b);
        }
        public void modulus()
        {
            Console.WriteLine("Enter first Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subtraction of {0} and {1} is : " + (a % b), a, b);
        }
        public void factorial()
        {
            Console.WriteLine("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int fact=1;
            for(int i = a; i >0; i--)
            {
                fact *= i;
            }
            Console.WriteLine("factorial of {0} is " + fact, a);
        }
        public void square()
        {
            Console.WriteLine("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("square  of {0} is " + (a*a), a);
        }
        public void cube()
        {
            Console.WriteLine("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("square  of {0} is " + (a*a*a), a);
        }
        public void powern()
        {
            Console.WriteLine("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter power : ");
            int pow = Convert.ToInt32(Console.ReadLine());
            int num=1;
            for(int i = 1; i <= pow; i++)
            {
                num *= a; 
            }
            Console.WriteLine("{0} to power  of {1} is : " + (num), a,pow);
        }

        public void exp()
        {
            Console.WriteLine("Enter Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("exponential of {0} is : " + Math.Exp(a),a);

        }
    }
}
