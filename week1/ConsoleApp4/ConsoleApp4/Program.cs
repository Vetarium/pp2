using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student
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
        public void Out(int year)
        {
            Console.WriteLine(name + " " + id + " " +  year+ " ");
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
            for (int i = 0; i< 4; i++)
            {
                yr = ++yr;
                s1.Out(yr);
                
            }
        }
    }
}
