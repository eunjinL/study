using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_TypeBasics
{
    class Program
    {
		struct Point
		{
			int x;  // 4 bytes
			int y;  // 4 bytes
		}

		struct A
		{
			byte b;  // 1 byte
			long l;  // 8 bytes
		}

		unsafe static void Main()
		{
			sizeof(Point).Dump();   // 8 bytes
			sizeof(A).Dump();       // 16 bytes
		}
	}
}