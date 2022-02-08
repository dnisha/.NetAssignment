using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {


            Person p = new Person();

            Student s = new Student();
            s.setAge(20);
            s.ShowAge();

            Teacher t = new Teacher();  
            t.setAge(30);
            t.Explain();
            Console.ReadLine();
        }
    }
    class Person
    {
       public int age;

        public Person()
        {
            Console.WriteLine("Hello");
        }
        public void setAge(int age)
        {
       this.age = age;
        }
        

    }
    class Teacher:Person
    {
        String subject;
     
        public void Explain()
        {
            Console.WriteLine("Explaination Begins");
        }
    }
    class Student:Person
    {
        public void GoToClass()
        {
            Console.WriteLine("I’m going to class");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is " + this.age+" ");
        }

    }
  
}
