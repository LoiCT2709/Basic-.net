using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan13_Static
{
    public class C
    {
        public static int x = 10;

        public int y;

        public static void F()
        {
            x = 1;
        }
        static C()
        {
            Console.WriteLine(x);
            Console.WriteLine("[x]");
        }
    }
}
