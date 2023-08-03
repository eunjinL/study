using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_remainder
{
    class ex_stack
    {
        static void Main()
        {
            Console.WriteLine(Factorial(5));
        }


        static int Factorial(int x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }
    }
}
