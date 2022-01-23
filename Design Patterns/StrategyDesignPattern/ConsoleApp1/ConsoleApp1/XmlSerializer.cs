using System;

namespace ConsoleApp1
{
    public class XmlSerializer:ISerializable
    {
        public void Serialize(string str)
        {
           Console.WriteLine("Xml Serileştirme");
        }

        public void DeSerialize(string str)
        {
            Console.WriteLine("Xml ters Serileştirme");
        }
    }
}