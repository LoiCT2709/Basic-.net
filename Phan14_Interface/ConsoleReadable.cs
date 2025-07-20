using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Phan14_Interface
{
    internal class ConsoleReadable : IReadable
    {
        public string name => throw new NotImplementedException();
        public int ReadInt()
        {
            Console.WriteLine("Nhap int: ");
            return int.Parse(Console.ReadLine());
        }

        public string  ReadString()
        {
            Console.WriteLine("Nhap string: ");
            return Console.ReadLine();
        }
    }
}
