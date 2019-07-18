using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DemoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dummyLines = "This is first line." + Environment.NewLine +
            //        "This is second line." + Environment.NewLine +
            //        "This is third line.";


            ////Opens DummyFile.txt and append lines. If file is not exists then create and open.
            //File.AppendAllLines(@"C:\Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\DummyFile.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());


            //Check whether file is exists or not at particular location
            bool isFileExists = File.Exists(@"C: \Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\DummyFile.txt"); // returns false

            //Copy DummyFile.txt as new file DummyFileNew.txt
            File.Copy(@"C: \Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\DummyFile.txt", @"C: \Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\NewDummyFile.txt");

            //Get when the file was accessed last time 
            DateTime lastAccessTime = File.GetLastAccessTime(@"C: \Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\DummyFile.txt");

            //get when the file was written last time
            DateTime lastWriteTime = File.GetLastWriteTime(@"C: \Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\DummyFile.txt");

            // Move file to new location
            File.Move(@"C:\DummyFile.txt", @"C: \Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\DummyFile.txt");

            //Open file and returns FileStream for reading bytes from the file
            FileStream fs = File.Open(@"C: \Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\DummyFile.txt", FileMode.OpenOrCreate);

            //Open file and return StreamReader for reading string from the file
            StreamReader sr = File.OpenText(@"C: \Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\DummyFile.txt");

            //Delete file
            File.Delete(@"C: \Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoFiles\DummyFile.txt");

            Console.Read();
        }
    }
}
