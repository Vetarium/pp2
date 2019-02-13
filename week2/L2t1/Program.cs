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
        static bool Ispol(string a) //create a function to try polindrom
        {
            string b = new string(a.ToCharArray().Reverse().ToArray()); // convert str to char array reverse all of them and covert back to str
           /* if (a == b) { return true; } */  //it works but it is not correct 
           if(String.Compare(a , b) ==0) { return true; }  //use string.compare because string is complex container 

            else return false;
        }
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\testf\text\sample.txt", FileMode.Open, FileAccess.Read);  //open file 
            StreamReader sr = new StreamReader(fs);

            string str = sr.ReadLine(); //take info from file to string 

            if (Ispol(str)) //ceck is it polindrom
            {
                Console.WriteLine("yep");
            }
            else Console.WriteLine("nope");



        }
    }
}
