using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_remainder
{
    class ex_ref
    {
		static void Foo(ref int p)
		{
			p = p + 1;
			Console.WriteLine(p);
		}

		static void Main()
		{
			int x = 8;
			Foo(ref x);
			Console.WriteLine(x);   // 9
		}
	}
}
