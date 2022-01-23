namespace ConsoleApp1
{
    public interface ISerializable
    {
        void Serialize(string str);
        void DeSerialize(string str);
    }
}