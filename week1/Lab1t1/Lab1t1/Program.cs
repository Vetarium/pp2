using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1t1
{
    class Program
    {
        static bool Isprim(int n) //create function which will check primes
        {
            if (n == 1) {
                return false; }
            for(int i=2; i<= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            
            int cnt = 0; // counter of prime numbers
            int m = Convert.ToInt32(Console.ReadLine()); // get amount of numbers from string to int
            int[] arry = new int[m];   
            string[] str = new string[888];
            str = Console.ReadLine().Split(); //get a string from console and divide by parts 
            for(int i=0; i<m; i++)
            {
                arry[i] = Convert.ToInt32(str[i]); //get numbers from string to array 
                if (Isprim(arry[i])) //check our nubers by function 
                {
                    cnt++; //count prime nubers
                }
                


            }
            Console.WriteLine(cnt);

            for (int j=0; j<arry.Length; j++)
            {
                if(Isprim(arry[j]))
                Console.Write(arry[j] + " ");
            }
                





        }
          
           

    }
}
