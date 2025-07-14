using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan12_Polymorphism
{
    internal class Pitbull:Dog
    {
        public override void High()
        {
            Console.WriteLine("40cm");
        }
        /*public override void Move()
        {
            Console.WriteLine("Pitbull run");
        }*/
    }
}
