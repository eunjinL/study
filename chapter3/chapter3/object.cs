using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class @object
    {
		public class Stack
		{
			int position;
			object[] data = new object[10];
			public void Push(object obj) { data[position++] = obj; }
			public object Pop() { return data[--position]; }
		}

		static void Main()
		{
			Stack stack = new Stack();
			stack.Push("sausage");
			string s = (string)stack.Pop();   
			Console.WriteLine(s);           

			stack.Push(3);
			int three = (int)stack.Pop();
		}
	}
}
