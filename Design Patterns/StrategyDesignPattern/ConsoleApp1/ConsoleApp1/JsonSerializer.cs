using System;

namespace ConsoleApp1
{
    public class JsonSerializer:ISerializable
    {
        public void Serialize(string str)
        {
            Console.WriteLine("Json Serileştirme");
        }

        public void DeSerialize(string str)
        {
            Console.WriteLine("Json Ters Serileştirme");
        }
    }
}