using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_remainder
{
    class ex_out
    {
		static void Split(string name, out string firstNames, out string lastName)
		{
			int i = name.LastIndexOf(' ');
			firstNames = name.Substring(0, i);
			lastName = name.Substring(i + 1);
		}

		static void Main()
		{
			string a, b;
			Split("Stevie Ray Vaughn", out a, out b);
			Console.WriteLine(a);                      
			Console.WriteLine(b);                   
		}
	}
}
