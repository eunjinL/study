using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class Boxing_Unboxing
    {
        static void Main(string[] args)
        {
            int x = 9;
            object obj = x;           // Box the int
            int y = (int)obj;         // Unbox the int

            Console.WriteLine(y);
        }
    }
}
