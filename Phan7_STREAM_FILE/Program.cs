using System.Net.WebSockets;

namespace Phan7_STREAM_FILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\";
            var dir = new DirectoryInfo(path);
            var directories = dir.GetDirectories();

            foreach (var d in directories)
            {
                Console.WriteLine($"{d.LastWriteTime:MM/dd/yyyy}");
            }
        }
    }
}
