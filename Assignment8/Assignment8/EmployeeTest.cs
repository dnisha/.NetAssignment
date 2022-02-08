using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class EmployeeTest
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee("mohan", "singh", 25000);
            Console.WriteLine(e1.getfname());
            Console.WriteLine(e1.getlname());
            Console.WriteLine(e1.getsalary());
            Console.WriteLine(e1.yearlysalary());
            Employee e2 = new Employee("anshu","kumar",50000);
            Console.WriteLine(e2.getfname());
            Console.WriteLine(e2.getlname());
            Console.WriteLine(e2.getsalary());
            Console.WriteLine(e2.yearlysalary());


            Console.ReadLine();

        }
    }

    class Employee
    {
        public String fname, lname;
        public double salary;

        public Employee(String fname,String lname, double salary)
        {
            this.fname = fname;
            this.lname = lname; 
            this.salary = salary;
        }

        public void setfname(String fname)
        {
            this.fname=fname;

        }

        public void setlname(String lname)
        {
            this.lname = lname;

        }

        public void setsalary(double salary)
           
        {
            if (salary < 0)
            {
                this.salary = 0.0;
            }
            else
            {
                this.salary = salary;
            }
              

        }
        public String getfname()
        {
            return this.fname;
        }

        public String getlname()
        {
            return this.lname;
        }

        public double getsalary()
        {
            return this.salary;
        }

        public double yearlysalary()
        {
            return 12*this.salary;
        }
    }
}
