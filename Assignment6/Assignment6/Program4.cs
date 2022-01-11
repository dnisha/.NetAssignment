using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            //Q4)
            int count = 0;
            int a= countnum(12345, count);

            Console.Write("Number count :");
            Console.WriteLine(a);
            Console.ReadLine();
        }

        public static int countnum(int n,int count)
        {
            if(n == 0)
            {
                return count;
            }

           
           int  a = n/ 10;
            count = count + 1;


            return countnum(a, count);


        }
    }
   
}
