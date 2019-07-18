using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1DemoXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter textWriter = new XmlTextWriter(@"C:\Users\DELL\Source\Repos\ASP.NET\Files And XML\CSharpDemo\1DemoXML\myxmlFile.xml", null);
            textWriter.WriteStartDocument();

            textWriter.WriteComment("First Comment XML Writer Sample");
            textWriter.WriteComment("xml root directory");

            textWriter.WriteStartElement("Student");
            textWriter.WriteStartElement("r", "Record", "urn:record");

            //Write Next Statement
            textWriter.WriteStartElement("Name", "");
            textWriter.WriteString("Student");
            textWriter.WriteEndElement();

            //Write Next Statement
            textWriter.WriteStartElement("Address", "");
            textWriter.WriteString("Colony");
            textWriter.WriteEndElement();

            textWriter.WriteEndDocument();
            textWriter.Close();
        }
    }
}
