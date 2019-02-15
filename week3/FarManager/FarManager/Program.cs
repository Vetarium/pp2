using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager
{
    class Layer // this class will display all info (folders and files)
    {
        public FileSystemInfo[] Content
        {
            get;
            set;

        }

        int selecItem;    

        public int SelecItem  //index of selected file or folder
        {
            get
            {
                return selecItem;

            }
            set
            {
                if(value < 0)  //чтобы переключать с первого на последний стрелкой вверх 
                {
                    selecItem = Content.Length - 1;
                }
                else if (value >= Content.Length) // чтобы переключать с последнего на первый для прокрутки 
                {
                    selecItem = 0;

                }
                else
                {
                    selecItem = value;
                }
            }
        }

        public void Window()  // method to display info (folder and files ) and to change colour of selected folder or file 
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear(); //clearing console by previous info
            for (int i=0; i< Content.Length; i++)
            {
                if (i== SelecItem)
                {
                    Console.BackgroundColor = ConsoleColor.Green; // selected one is focused by green colour and black letters
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                }
                Console.WriteLine((i + 1) + ". " + Content[i].Name);  // add order number and display name of folders and files
            }
        }
        
    }
    enum Farmode //mode to open, delete and rename things
    {
        File, //for files
        Directory // for folders 
             
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            DirectoryInfo origin = new DirectoryInfo(@"C:\testf"); //origin folders like start
            Stack<Layer> history = new Stack<Layer>(); // history of layers 
            Farmode farmd = Farmode.Directory; // default is folder 
            history.Push(new Layer { Content = origin.GetFileSystemInfos(), SelecItem = 0 });

            while (true)
            {
                if(farmd == Farmode.Directory)
                {
                    history.Peek().Window(); //saves latest history and displays it 

                }
                ConsoleKeyInfo consolekeyinfo = Console.ReadKey(); // structure wich allow to describe buttons of keyboard to substittude them to other action 
                switch (consolekeyinfo.Key)
                {
                    case ConsoleKey.UpArrow:           //motion up
                        history.Peek().SelecItem--;
                        break;

                    case ConsoleKey.DownArrow:           //motion doen
                        history.Peek().SelecItem++;
                        break;

                    case ConsoleKey.Enter:                 //entering to the folder or opening file 
                        int a = history.Peek().SelecItem;
                        FileSystemInfo fsi = history.Peek().Content[a];
                        if (fsi.GetType()== typeof(DirectoryInfo))
                        {
                            DirectoryInfo dri = fsi as DirectoryInfo;
                            history.Push(new Layer { Content = dri.GetFileSystemInfos(), SelecItem = 0 });
                        }

                        else
                        {
                            farmd = Farmode.File;         //openning file 
                            using(FileStream fstr = new FileStream(fsi.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using(StreamReader sr = new StreamReader(fstr))
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());

                                }
                            }
                        }
                        break;

                    case ConsoleKey.Backspace:                    //exit from file or back to parent folder 
                        if(farmd == Farmode.Directory)
                        {
                            history.Pop();

                        }
                        else if (farmd == Farmode.File)
                        {
                            farmd = Farmode.Directory;
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        break;

                    case ConsoleKey.Delete:                               //delet file or folder with child folders or files 
                        int b = history.Peek().SelecItem;
                        FileSystemInfo fsi2 = history.Peek().Content[b];
                        if(fsi2.GetType()== typeof(DirectoryInfo))
                        {
                            DirectoryInfo dri = fsi2 as DirectoryInfo;
                            Directory.Delete(fsi2.FullName, true);  //true means that we will delete folder and all it's content 
                            history.Peek().Content = dri.Parent.GetFileSystemInfos(); //after deleting displays parent folder 
                        }

                        else
                        {
                            FileInfo fin = fsi2 as FileInfo;
                            File.Delete(fsi2.FullName);
                            history.Peek().Content = fin.Directory.GetFileSystemInfos();


                        
                        }
                        history.Peek().SelecItem--;
                        break;

                    case ConsoleKey.Tab:                     //rename folder or file 
                        int c = history.Peek().SelecItem;
                        FileSystemInfo fsi3 = history.Peek().Content[c];  //save hitory
                        Console.Clear();  //clear console 
                        Console.WriteLine("write new name"); //shows text that we should input new name 
                        string newname = Console.ReadLine();     
                        if(fsi3.GetType() == typeof(DirectoryInfo)) 
                        {
                            DirectoryInfo dri = new DirectoryInfo(fsi3.FullName);
                            newname = newname.Insert(0, dri.Parent.FullName + "\\");  //inserts new name besides previous
                            dri.MoveTo(newname);
                            history.Pop();    //back to previous layer 
                            history.Push(new Layer { Content = dri.GetFileSystemInfos(), SelecItem = 0 }); //returns to the folder (to refresh info after changing)
                        }

                        else
                        {
                            FileInfo fin = new FileInfo(fsi3.FullName);
                            newname = newname.Insert(0, fin.DirectoryName + "\\");
                            fin.MoveTo(newname);
                            history.Pop();
                            history.Push(new Layer { Content = fin.Directory.GetFileSystemInfos(), SelecItem = 0 });

                        }
                        history.Peek().SelecItem--;
                        break;

                }
            }
            
            

        }
    }
}
