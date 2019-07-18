using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DemoFileStreamWriter
{

    class Program
    {
       

        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.WriteData();
        }

        public void WriteData()
        {
            FileStream fs = new FileStream(@"C:\Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\4DemoFileStreamWriter\test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text which you want to write to the file");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();

        }
    }
}
