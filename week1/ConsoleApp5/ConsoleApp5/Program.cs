using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // read info about size of triangle
            for (int i = 0; i < n; i++)                   //create two arrays this is horizontal location 
            {
                for (int j = 0; j <= i; j++)             //vertical location
                {
                    Console.Write("[*]");

                }
                Console.WriteLine(); 
            } 
        }
    }
}
