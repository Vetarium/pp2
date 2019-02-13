using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2t2
{
    class Program
    {
        static bool Isprim(int a)  //function to chech primes
        {
            if (a == 1)
            {
                return false;
            }
            for (int i =2; i<= Math.Sqrt(a); i++)
            {
                if(a % i == 0)
                {
                    return false;
                }
                    
            }
            return true;
            
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\testf\text\sample2.txt", FileMode.Open, FileAccess.Read); //open file
            StreamReader sr = new StreamReader(fs); //read info from file

           

            string[] str = sr.ReadLine().Split(); //take file content to the str 
            sr.Close();
            fs.Close();
            
            string res = "";
            int[] ar = new int[str.Length]; 
            for(int i = 0; i<ar.Length; i++)
            {
                ar[i] = int.Parse(str[i]); //check all numbers is it prime 
                if (Isprim(ar[i]))
                {
                    res += ar[i];
                    res += " ";
                    
                }
            }

            FileStream fs2 = new FileStream(@"C:\testf\text\sample21.txt", FileMode.Open, FileAccess.Write); //open new file 
            StreamWriter sw = new StreamWriter(fs2); // write there only primes 
            sw.WriteLine(res);
            sw.Close();
            fs2.Close();
            



        }
    }
}
