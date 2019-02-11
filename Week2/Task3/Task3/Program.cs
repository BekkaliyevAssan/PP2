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
        static void WriteEmptySpaces(int level)
        {
            for (int i = 0; i < level * 4; i++)
                Console.Write(" ");
        }

        static void Ex4(string path, int level)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles();
            foreach (FileInfo file in files)
            {
                WriteEmptySpaces(level);
                Console.WriteLine(file.Name);
            }
            DirectoryInfo[] directories = d.GetDirectories();
            foreach (DirectoryInfo directory in directories)
            {
                WriteEmptySpaces(level);
                Console.WriteLine(directory.Name);
                Ex4(directory.FullName, level + 1);
            }
        }
        static void Main(string[] args)
        {
            Ex4(@"C:\Users\Fora\source\repos\Week2", 0);
            Console.ReadKey();
        }
    }
}