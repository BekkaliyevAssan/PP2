using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileManager
{
    class Program
    {
        static int CONSOLE_SIZE = 30;
        static void Refresh(DirectoryInfo directory, int cursor, int first)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileSystemInfo[] files = directory.GetFileSystemInfos();
            int index = 0;
            for (int i = 0; i < files.Length; i++)
            {
                if (index == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (files[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.ForegroundColor = ConsoleColor.Magenta;
                if (i == cursor)
                {

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                if (index >= first && index <= first + CONSOLE_SIZE)
                    Console.WriteLine(files[i].Name);
                index++;

            }


        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //string path = @"C:\...\...";
            //DirectoryInfo Dir = newDirectoryInfo(path);
            DirectoryInfo Dir = new DirectoryInfo(@"C:\");
            int cursor = 0;
            int first = 0;
            int n = Dir.GetFileSystemInfos().Length;
            Refresh(Dir, cursor, first);
            bool onoff = true;
            while (onoff)
            {
                ConsoleKeyInfo button = Console.ReadKey();
                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        cursor--;
                        if (cursor < 0)
                        {
                            cursor = n - 1;
                            first = cursor - CONSOLE_SIZE;
                        }
                        if (cursor < first)
                        {
                            first--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        cursor++;
                        if (cursor == n)
                        {

                            cursor = 0;
                            first = 0;

                        }
                        if (cursor > first + CONSOLE_SIZE)
                        {
                            first++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (Dir.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                        {
                            Dir = new DirectoryInfo(Dir.GetFileSystemInfos()[cursor].FullName);
                            cursor = 0;
                            n = Dir.GetFileSystemInfos().Length;
                            first = 0;
                        }
                        else
                        {
                            StreamReader sr = new StreamReader(Dir.GetFileSystemInfos()[cursor].FullName);
                            string s = sr.ReadToEnd();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(s);
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.Backspace:
                        if (Dir.Parent != null)
                        {
                            Dir = Dir.Parent;
                            cursor = 0;
                            n = Dir.GetFileSystemInfos().Length;
                            first = 0;
                        }
                        break;
                    case ConsoleKey.Escape:
                        onoff = false;
                        break;
                    case ConsoleKey.D:
                        /* foreach (FileSystemInfo i in Dir.GetFileSystemInfos())
                         {
                             if (i is FileInfo)
                             {
                                 FileInfo dellFile = new FileInfo(Dir.GetFileSystemInfos()[cursor].FullName);
                                 dellFile.Delete();
                             }
                             if (i is DirectoryInfo)
                             {
                                 string dellDir = new string(Dir.GetFileSystemInfos()[cursor].FullName);
                                 Directory.Delete(dellDir, true);
                             }
                         }*/
                        string dellDir = new string(Dir.GetFileSystemInfos()[cursor].FullName);
                        Directory.Delete(dellDir, true);
                        break;
                    case ConsoleKey.F:
                        FileInfo dellFile = new FileInfo(Dir.GetFileSystemInfos()[cursor].FullName);
                        dellFile.Delete();
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine();
                        string ss = Console.ReadLine();
                        if (Dir.GetType() == typeof(DirectoryInfo))
                        {
                            string location = new string(Dir.GetFileSystemInfos()[cursor].FullName);
                            string newLocation = Directory.GetParent(location).FullName;
                            Directory.Move(location, newLocation + ss);
                        }
                        else if (Dir.GetType() == typeof(FileInfo))
                        {
                            string location = new string(Dir.GetFileSystemInfos()[cursor].FullName);
                            string newLocation = Directory.GetParent(location).FullName;
                            File.Move(location, newLocation + ss);
                            //SUKA TUT BACKSLASH
                        }
                        break;
                    default:
                        break;
                }
                Refresh(Dir, cursor, first);
            }
        }
    }
}