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
        public void Out() //function of output info about student
        {
            Console.WriteLine(name + " " + id + " " +  year + " ");
        }
        
        public void Incr() // increment of study year function 
        {
            year++;
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            string nm = Console.ReadLine();
            string num = Console.ReadLine();                  // read info about student
            int yr = int.Parse(Console.ReadLine());

            Student s1 = new Student(nm, num, yr);            
            s1.Out();   //output info 
            s1.Incr();   //incerease year of study
            s1.Out();      // output of updated info

        
        
                
                
            
        }
    }
}
