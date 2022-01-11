using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            //Q5)

            //even(1,20);
            odd(1,20);
            Console.ReadLine();
        }

        static void even(int L ,int R)
        {
            if(R < L)
            {
                return;
            }

          
            even(L,R - 1);
            if (R % 2 == 0 && R > 0)
            {
                Console.Write(R + "\t");
            }


          
        }

        static void odd(int L, int R)
        {
            if (R < L)
            {
                return;
            }


            odd(L, R - 1);
            if (R % 2 != 0 && R > 0)
            {
                Console.Write(R + "\t");
            }



        }
    }
}
