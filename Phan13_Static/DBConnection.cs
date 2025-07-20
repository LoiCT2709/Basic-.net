using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan13_Static
{
    internal class DBConnection
    {
        private static DBConnection? instance = null;
        private static object _lock = new object();
        public static DBConnection GetInstance()
        {
           lock(_lock)
            {
                if (instance == null)
                {
                    instance = new DBConnection();
                    instance.Connect();
                }
                return instance;
            }
        }
        private int Connect()
        {
            throw new NotImplementedException();
        }
    }
}
