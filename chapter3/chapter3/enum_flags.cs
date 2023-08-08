using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class enum_flags
    {
		public enum BorderSides { Left = 1, Right = 2, Top = 4, Bottom = 8 }

		static bool IsFlagDefined(Enum e)
		{
			decimal d;
			return !decimal.TryParse(e.ToString(), out d);
		}

		static void Main()
		{
			for (int i = 0; i <= 16; i++)
			{
				BorderSides side = (BorderSides)i;
				Console.WriteLine(IsFlagDefined(side) + " " + side);
			}
		}
	}
}
