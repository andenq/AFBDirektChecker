using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFBDirektChecker
{
    class Util
    {
        public static void PrintArray<T>(IEnumerable<T> array)
        {
            foreach (T obj in array)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
