namespace Phan14_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DatabaseReadable();
            Run(reader);
          
        }
        static void Run(IReadable reader)
        {
            //Phuong thuc tu extension
            reader.WriteName();
            IReadable.ReadName(reader);
            Console.WriteLine(reader.name);

            int n = reader.ReadInt();

            string s = reader.ReadString();

            Console.WriteLine($"int: {n}, string: {s}");
        }
    }
}
