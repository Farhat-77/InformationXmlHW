using System;
using System.Xml;

namespace InformationXmlHW
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("С://users.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "company")
                    {
                        Console.WriteLine($"Компания: {childnode.InnerText}");
                    }
                    if (childnode.Name == "age")
                    {
                        Console.WriteLine($"Возраст: {childnode.InnerText}");
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
