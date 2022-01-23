using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Serializer serializer = new Serializer(new XmlSerializer());
            serializer.Serialize("Bülent Serttaş");
            serializer.DeSerialize("İsmail Türüt");

            serializer = new Serializer(new BinarySerializer());
            serializer.Serialize("Bülent Serttaş");
            serializer.DeSerialize("İsmail Türüt");

            serializer = new Serializer(new JsonSerializer());
            serializer.Serialize("");
            serializer.DeSerialize("");
        }
    }
}