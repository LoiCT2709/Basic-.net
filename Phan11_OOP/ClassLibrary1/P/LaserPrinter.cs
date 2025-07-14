using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.P
{
    public class LaserPrinter : Printer
    {
        public LaserPrinter(string name):base(name) { }
        public override void MyAbstractMethod()
        {
            throw new NotImplementedException();
        }
    }
}
