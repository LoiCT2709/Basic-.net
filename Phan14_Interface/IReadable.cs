using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan14_Interface
{
    internal interface IReadable
    {
        string name { get; }
        int ReadInt();
        string  ReadString();
        
        static IReadable()
        {

        }
        //Phuong thuc static
        public static void ReadName(IReadable readable)
        {
            Console.WriteLine(readable.name);

        }

    }
}
