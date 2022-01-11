using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            /*
            Console.Write("Enter number of Rows : ");
           int r = Convert.ToInt32( Console.ReadLine());
            for(int i=0; i<=r; i++)
            {
                int d = i + 1;
                for (int j = 0; j <= i; j++)
                {
                   
                    Console.Write(d+" \t");
                    d = d - 1;
                    
                   
                }
                Console.WriteLine();
               
            }
            Console.ReadLine();
            */

            //Q2
            /*
            for(int  i=1;i<=4; i++)
            {
                int k = i;
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(k+" \t");
                    if (j == 2)
                        k = k + 2;
                    else if (j == 3)
                        k = k + 1;
                    else
                        k = k + 3;
                }
                Console.WriteLine();
            }
            
           
            Console.ReadLine();
            */

            //Q3
            /*
              Console.WriteLine("The pattern is : ");

              for (int i = 0; i < 3; i++)
              {
                  for (int j = 0; j < 3; j++)
                  {
                      Console.Write(i+1+" \t");
                  }
                  Console.WriteLine();

              }
              Console.ReadLine();
            */
            //Q4)
            /*

            Console.WriteLine("The pattern is : ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(j + 1 + " \t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            */

            //Q5)
            /*
            Console.WriteLine("The pattern is : ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j+1 + " \t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            */
            //Q6)
            /*
            Console.WriteLine("The pattern is : ");

            for (int i = 3; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i  + " \t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();

            */
            // Q7)
            /*
            Console.WriteLine("The pattern is : ");
            int count = 1;

            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.Write(count + " \t");
                    count = count + 1;
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            */

            //Q8)
            /*
            Console.WriteLine("The pattern is : ");
            int count = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(count + " \t");
                    count = count + 1;
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            */
            //Q9)
            /*
            Console.WriteLine("The pattern is : ");
            int x = 65;
           

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write(Convert.ToChar(x)+ " \t");
                    x = x + 1;
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            */
            //Q10)
            /*
            Console.WriteLine("The pattern is : ");
         


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*' + " \t");
                   
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            */
            //Q11)
            /*
            Console.WriteLine("The pattern is : ");
   


            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j <i; j++)
                {
                    Console.Write('*'+ " \t");
                   
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            */
            //Q12)
            /*
            Console.WriteLine("The pattern is : ");
           


            for (int i = 4; i >=0; i--)
            {
                for (int j = 0; j <=4-i; j++)
                {
                    Console.Write(' ' + " \t");
                   
                }

                for (int j = 0; j <= i ; j++)
                {
                    Console.Write('*' + " \t");

                }
                Console.WriteLine();

            }
            Console.ReadLine();
            */


            //Q13
            /*
            Console.WriteLine("The pattern is : ");
          
            for (int i = 0; i < 5; i++)
            {
                int x = 5;
                for (int j = 0;j<=i;j++)
                {
                    Console.Write(x+" \t");
                    x = x - 1;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //Q14)
            /*
            Console.WriteLine("The pattern is : ");
            for (int i = 7; i > 0; i--)
            { 
                if(i > 3)
                {
                for (int j = 0; j <= 7-i; j++)
                
                    Console.Write('*' + " \t");

                }
                else
                {
                    for (int j = i-1; j >=0; j--)
                        Console.Write('*' + " \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */

            //Q15
            /*
            Console.WriteLine("The pattern is : ");
            for(int j = 5; j > 0; j--)
            {
                int x = 5;
                for (int i = j; i >0 ; i--)
                {
                   
                    Console.Write(x+" \t");
                    x = x - 1;

                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //Q16
            /*
            Console.Write("Enter size of array : ");
            int s = Convert.ToInt32(Console.ReadLine());

            int [] a = new int[s];

            for (int i = 0; i < s; i++)
            {
                Console.Write("Enter value at index "+i+" : ");
                 a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+"\t");
            }
            Console.ReadLine();
            */

            //Q17
            /*
            Console.Write("Enter size of array : ");
            int s = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[s];

            for (int i = 0; i < s; i++)
            {
                Console.Write("Enter value at index " + i + " : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array in reverse order : ");
            for (int i = a.Length-1; i >= 0; i--)
            {
                Console.Write(a[i] + "\t");
            }
            Console.ReadLine();
            */

            //Q18
            /*

            Console.Write("Enter size of array : ");
            int s = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[s];

            for (int i = 0; i < s; i++)
            {
                Console.Write("Enter value at index " + i + " : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum of Array : ");
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum+a[i] ;
            }
            Console.Write(sum);
            Console.ReadLine();

            */

            //Q19
            /*

            Console.Write("Enter size of array : ");
            int s = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[s];
            int []b=new int[a.Length];

            for (int i = 0; i < s; i++)
            {
                Console.Write("Enter value at index " + i + " : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
         
            for (int i = 0; i < a.Length; i++)
            {
                b[i]= a[i];
            }

            Console.WriteLine("Another array : ");

         
                b = a;
          

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(b[i]  + '\t');
            }
            Console.ReadLine();
            */
            //Q20
            /*
            int[,] a = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value at index " + i + " & " + j + " : ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Array value : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " \t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */


            /*
            //Q21
            Console.Write("Enter row of array : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column of array : ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[r,c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("Enter value at index " + i + " & "+j+" : ");
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Array value : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j]+" \t");
                  
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            //Q22
            /*
            Console.Write("Enter row of array : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column of array : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter z of array : ");
            int z = Convert.ToInt32(Console.ReadLine());

            int[, ,] a = new int[r, c,z];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("Enter value at index " + i + " & " + j + " & " + z +" : ");
                        a[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Array value : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write(a[i, j, k] + " \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */

            //Q23
            Console.Write("Enter no. of rows");

            int iNoRows = Convert.ToInt32(Console.ReadLine());
            int[][] arr1 = new int[iNoRows][];
            Console.WriteLine();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter no. of columns for row" + (i + 1) + ":");
                arr1[i] = new int[Convert.ToInt32(Console.ReadLine())];
            }

            Console.WriteLine();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write("Enter value for Row " + (i + 1) + ", Column " + (j + 1) + ":");

                    arr1[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Reading values of Jagged Array.....");


            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j] + "\t");

                }
                Console.WriteLine();

            }

            Console.ReadLine();
        
    


        }
    }
}
