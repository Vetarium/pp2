using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2t4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\testf\ds\sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            string str = "text for task4";
            sw.WriteLine(str);
            sw.Close();
            fs.Close();

            File.Copy(@"C:\testf\ds\sample.txt", @"C:\testf\ds2\copiedsample.txt");
            File.Delete(@"C:\testf\ds\sample.txt");
        }
    }
}
