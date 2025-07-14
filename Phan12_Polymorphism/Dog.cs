using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan12_Polymorphism
{
    internal class Dog:Animal
    {
        public sealed override void Move()
        {
            //base.Move();
            Console.WriteLine("Run");
        }
        public virtual void High()
        {
            //
        }
    }
}
