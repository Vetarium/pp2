using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2t1
{
    class Program
    {
        static bool Ispol(string a)
        {
            string b = new string(a.ToCharArray().Reverse().ToArray()); // convert str to char array reverse all of them and covert back to str
           /* if (a == b) { return true; } */
           if(String.Compare(a , b) ==0) { return true; }

            else return false;
        }
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\testf\text\sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string str = sr.ReadLine();

            if (Ispol(str))
            {
                Console.WriteLine("yep");
            }
            else Console.WriteLine("nope");



        }
    }
}
