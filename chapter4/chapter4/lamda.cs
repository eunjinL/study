﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter4
{
    class lamda
    {
        delegate int Transformer(int i);

		static void Main()
		{
			Transformer sqr = x => x * x;
			Console.WriteLine(sqr(3));    // 9

			// Using a statement block instead:
			Transformer sqrBlock = x => { return x * x; };
			Console.WriteLine(sqr(3));

			// Using a generic System.Func delegate:
			Func<int, int> sqrFunc = x => x * x;
			Console.WriteLine(sqrFunc(3));

			// Using multiple arguments:
			Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
			int total = totalLength("hello", "world");
			Console.WriteLine(total); 

			// Explicitly specifying parameter types:
			Func<int, int> sqrExplicit = (int x) => x * x;
			Console.WriteLine(sqrFunc(3));
		}

	}
}
