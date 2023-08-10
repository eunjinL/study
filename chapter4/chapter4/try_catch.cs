using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter4
{
    class try_catch
    {
		static int Calc(int x) { return 10 / x; }

		static void Main()
		{
			try
			{
				int y = Calc(0);
				Console.WriteLine(y);
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("x cannot be zero");
			}
			Console.WriteLine("program completed");
		}
	}
}
