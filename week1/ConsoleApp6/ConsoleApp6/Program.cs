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
            for (int i=0; i<str.Length; i++)
            {
                int a = int.Parse(str[i]);
                for( int j=0; j<2; j++)
                {
                    Console.Write(a + " ");
                }
            }
        }
    }
}
