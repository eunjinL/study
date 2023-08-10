using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter4
{
    class throwing_exception
    {
		static void Display(string name)
		{
			if (name == null)
				throw new ArgumentNullException(nameof(name));

			Console.WriteLine(name);
		}

		static void Main()
		{
			try
			{
				Display(null);
			}
			catch (ArgumentNullException ex)
			{
				Console.WriteLine("Caught the exception");
			}
		}
	}
}
