using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Phan14_Interface
{
    internal class DatabaseReadable:IReadable
    {
       
        public string name => "DatabaseReadable";

        public int ReadInt()
        {
    
            return 0; 
        }

        public string ReadString()
        {
            return "hello";
        }
    }
}
