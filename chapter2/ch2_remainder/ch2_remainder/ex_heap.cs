using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_remainder
{
    class ex_heap
    {
        static void Main()
        {
            StringBuilder ref1 = new StringBuilder("object1");
            Console.WriteLine(ref1);

            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 = ref2;

            Console.WriteLine(ref3);
        }
    }
}
