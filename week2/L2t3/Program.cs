using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2t3
{
    class Program
    {
        public static void Out(FileSystemInfo fsi, int n) //create a function which will show our directory in the stairs
        {
            string line = new string(' ', n); //create a string of spaces n times 
            line = line + fsi.Name;  //n times spaces + name of directory / file folder
            Console.WriteLine(line);

            if (fsi.GetType() == typeof(DirectoryInfo)) //if variable fsi as directory info type gets it shows content according Out function
            {
                var items = (fsi as DirectoryInfo).GetFileSystemInfos(); //kepp info about content of directory
                foreach (var i in items) //out all content by the Out function with the step of 3 spaces
                {
                    Out(i, n + 3);
                }
            }
        }
            static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\testf"); //direcory 
            Out(dir, 1);
        }
    }
}
