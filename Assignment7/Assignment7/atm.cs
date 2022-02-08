using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class atm
    {
        static int pin = 123;
       static float bal;
        static void Main(String [] args)
        {
            Console.WriteLine("!!________________Welcome________________!!");
            Console.WriteLine("Enter Password : ");
            int p = Convert.ToInt32(Console.ReadLine());
        
            if (pin == p)
            {
                menu();
            }
            else
            {
                Console.WriteLine("You Entered Incorrect Password");
            }
           
            Console.ReadLine();
        }
        public static void menu()
        {
          

          
                Console.WriteLine("Press 1 for balance enquiry :");
                Console.WriteLine("Press 2 for withdraw money :");
                Console.WriteLine("Press 3 for deposit money :");
                Console.WriteLine("Press 4 for Exit :");
                Console.WriteLine("What do you want to perform :");
                int o = Convert.ToInt32(Console.ReadLine());

                atm a = new atm();
                switch (o)
                {
                    case 1:
                        a.balance();

                        break;
                    case 2:
                        a.withdraw();
                        break;
                    case 3:
                        a.deposit();
                        break;

                }
            
         
        }
       public void balance()
        {
            Console.WriteLine("Your balance : " + bal);
            menu();
        }
        public void withdraw()
        {
            Console.WriteLine("Enter the amout to withdraw : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            bal = bal - amount;
            menu();

        }
        public void deposit()
        {
            Console.WriteLine("Enter the amout you want to deposit : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            bal = bal + amount;
            menu();

        }
    }
}
