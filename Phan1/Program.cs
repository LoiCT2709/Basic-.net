namespace Phan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}
