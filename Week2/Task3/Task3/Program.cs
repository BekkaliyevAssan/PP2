using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void WriteEmptySpaces(int level)//creating new method for free space
        {
            for (int i = 0; i < level * 4; i++)
                Console.Write(" ");
        }

        static void Ex4(string path, int level)//method that works with source and deepness of the directory
        {
            DirectoryInfo d = new DirectoryInfo(path);//returns info about the directory
            FileInfo[] files = d.GetFiles();//making array that contains files from directory. It is done my Get.Files method
            foreach (FileInfo file in files)
            {
                WriteEmptySpaces(level);//leave free space for every FileInfo
                Console.WriteLine(file.Name);//and show its name
            }
            DirectoryInfo[] directories = d.GetDirectories();//new array for directories form d with the method Get.Directories()
            foreach (DirectoryInfo directory in directories)
            {
                WriteEmptySpaces(level);//leave free space by method that have been created
                Console.WriteLine(directory.Name);//show the name
                Ex4(directory.FullName, level + 1);//recursevly go into every folder, showing its name and increasing level(deepness)
            }
        }
        static void Main(string[] args)
        {
            Ex4(@"C:\Users\Fora\source\repos\Week2", 0);//initial directory and initial value of level
            Console.ReadKey();
        }
    }
}
