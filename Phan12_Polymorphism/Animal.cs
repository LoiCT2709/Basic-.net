using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan12_Polymorphism
{
    internal class Animal
    {
        public virtual void Move()
        {
            Console.WriteLine("Walk");
        }
    }
}
