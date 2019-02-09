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
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            int[] arr = new int[str.Length];

            List<int> numbers = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {

                numbers.Add(int.Parse(str[i]));
                numbers.Add(int.Parse(str[i]));
            }
            foreach (var x in numbers)
            {
                Console.Write(x + " " );
            }
        }
            
    }
}   

