using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_remainder
{
    class ex_notref
    {
		static void Foo(int p)
		{
			p = p + 1;
			Console.WriteLine("p is " + p);
		}

		static void Main()
		{
			int x = 8;
			Foo(x);
			Console.WriteLine("x is " + x); // 8
		}
	}
}
