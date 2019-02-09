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
        public static void Out(FileSystemInfo fsi, int n)
        {
            string line = new string(' ', n);
            line = line + fsi.Name;
            Console.WriteLine(line);

            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                var items = (fsi as DirectoryInfo).GetFileSystemInfos();
                foreach (var i in items)
                {
                    Out(i, n + 3);
                }
            }
        }
            static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\testf");
            Out(dir, 1);
        }
    }
}
