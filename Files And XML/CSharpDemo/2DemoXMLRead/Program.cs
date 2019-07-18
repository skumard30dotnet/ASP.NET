using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2DemoXMLRead
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoXML\myxmlFile.xml");
            Console.Write(doc.DocumentElement.OuterXml);

            XmlNode root = doc.FirstChild;

            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    Console.WriteLine(root.ChildNodes[i].InnerXml);
                    Console.WriteLine(root.ChildNodes[i].InnerText);
                }
            }

            DataSet ds = new DataSet();
            ds.GetXml();

            Console.Read();
        }
    }
}
