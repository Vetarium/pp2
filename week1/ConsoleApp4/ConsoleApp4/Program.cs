using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student //create student class
    {
        public string name;
        public string id;
        public int year; 

        public Student(string nm, string num, int yr)
        {
            name = nm;
            id = num;
            year = yr;
        }
        public void Out()
        {
            Console.WriteLine(name + " " + id + " " +  year + " ");
        }
        
        public void Incr()
        {
            year++;
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            string nm = Console.ReadLine();
            string num = Console.ReadLine();
            int yr = int.Parse(Console.ReadLine());

            Student s1 = new Student(nm, num, yr);
            s1.Out();
            s1.Incr();
            s1.Out();


        
                
                
            
        }
    }
}
