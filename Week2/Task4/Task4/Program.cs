using System;
using System.Text;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"C:\Users\Fora\source\repos\Week2";//showing full name of the folder
            string path1String = System.IO.Path.Combine(folderName, "path1");//convert the name of the folder into the string 
            System.IO.Directory.CreateDirectory(path1String);//creating folder for the new file


            string fileName = "Original.txt";//creating name of the file
            path1String = System.IO.Path.Combine(path1String, fileName);//SOME STUFF FORM THE FORUM
            Console.WriteLine("Path to my new file is {0}\n", path1String);//showing new full name of the file

            // Just for fun)))

            const string specialMessage = "Hello from Hell with love";
            byte[] bArray = Encoding.UTF8.GetBytes(specialMessage);

            //

            using (System.IO.FileStream fs = System.IO.File.Create(path1String)) //method USING to write something into txt file
            {
                for (int i = 0; i < bArray.Length; i++)
                {
                    fs.WriteByte(bArray[i]);//using UTF8 coding
                }
            }
            string path2String = System.IO.Path.Combine(folderName, "path2");//convert the name of the folder into the string 
            System.IO.Directory.CreateDirectory(path2String);//creating folder for the new file

            string sourcePath = @"C:\Users\Fora\source\repos\Week2\path1";//full name of the initial folder
            string targetPath = @"C:\Users\Fora\source\repos\Week2\path2";//full name of the secondary folder

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);//full name of the initial file
            string destFile = System.IO.Path.Combine(targetPath, fileName);//full name of the secondary file

            System.IO.File.Copy(sourceFile, destFile, true);//method that copies file from one folder to another

            // Section to delete the intial one

            
            
            if (System.IO.File.Exists(@"C:\Users\Fora\source\repos\Week2\path1\Original.txt"))//cheking for the existance of such file
            {
                System.IO.File.Delete(@"C:\Users\Fora\source\repos\Week2\path1\Original.txt");//if yes, then delete it
                Console.WriteLine("Hello world"); // this line was just for test))
            }

        }
    }
}
