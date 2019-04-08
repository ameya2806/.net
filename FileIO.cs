using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic directory info
            DirectoryInfo Dir = new DirectoryInfo(".");
            DirectoryInfo hello = new DirectoryInfo(@"C:\lol");
            Console.WriteLine("Directory basic information:");
            Console.WriteLine(hello.FullName);
            Console.WriteLine(hello.Name);
            Console.WriteLine(hello.Parent);
            Console.WriteLine(hello.Attributes);
            Console.WriteLine(hello.CreationTime);

            //writing into the text file & printing it
            DirectoryInfo ameya = new DirectoryInfo(@"C:\lol\lol1\lol2");
            string[] customers = 
            {
                "Saurabh Kshirsagar",
                "Vikas Rathod",
                "Kshitij Jagtap"
            };
            string textFilePath = @"C:\lol\lol1\lol2\ameya.txt";
            File.WriteAllLines(textFilePath, customers);
            Console.WriteLine("Printing names from the file which were previously written:");
            foreach(string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine(cust);
            }

            //matching the .txt file content
            DirectoryInfo mydata = new DirectoryInfo(@"C:\lol\lol1\lol2");
            FileInfo[] txtFiles = mydata.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Printing names & sizes of files which match the .txt extension");
            Console.WriteLine("Matches : {0}", txtFiles.Length);
            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }

            //creating a new file
            string textFilePath2 = @"C:\lol\lol1\lol2\ameya.txt";
            FileStream fs = File.Open(textFilePath2, FileMode.Create);
            Console.WriteLine("New file created");

            //writing and reading into a file using streamwriter and streamreader
            string textFilePath3 = @"C:\lol\lol1\lol2\textFilePath.txt";
            StreamWriter sw = File.CreateText(textFilePath3);
            Console.WriteLine("Contents of that file are:");
            sw.Write("Bojack Horseman");
            sw.WriteLine("House of cards");
            sw.WriteLine("Game of thrones");
            sw.Close();
            StreamReader sr = File.OpenText(textFilePath3);
            Console.WriteLine("1st String: {0}", sr.ReadLine());
            Console.WriteLine("2nd String: {0}", sr.ReadToEnd());
            sr.Close();

            Console.ReadLine();
        }
    }
}
