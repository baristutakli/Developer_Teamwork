namespace ConsoleApp1
{
    public class Serializer
    {
        // Context Type
        private ISerializable _serializer;

        public Serializer(ISerializable serializer)
        {
            _serializer = serializer;
        }

        public void Serialize(string str)
        {
            _serializer.Serialize(str);
        }

        public void DeSerialize(string str)
        {
            _serializer.DeSerialize(str);
        }
    }
}