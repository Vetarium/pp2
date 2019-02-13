using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());        // read amount of numbers
            string[] str = Console.ReadLine().Split();     //read numbers
           

            List<int> numbers = new List<int>();  // use list to make double array
            for (int i = 0; i < str.Length; i++)
            {

                numbers.Add(int.Parse(str[i]));   //add i 1st time
                numbers.Add(int.Parse(str[i]));     // add i 2nd time 
            }
            foreach (var x in numbers)
            {
                Console.Write(x + " " );
            }
        }
            
    }
}   

