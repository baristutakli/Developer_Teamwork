using System;

namespace ConsoleApp1
{
    public class BinarySerializer:ISerializable
    {
        public void Serialize(string str)
        {
            Console.WriteLine("Binary Serileştirme");
        }

        public void DeSerialize(string str)
        {
            Console.WriteLine("Binary Ters Serileştirme");
        }
    }
}