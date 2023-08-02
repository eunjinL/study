using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_TypeBasics
{
    class Program
    {
		public class Dog
		{
			public string Name;             // 인스턴스 필드 
			public static int Population;   // 정적 필드 

			public Dog(string n)           // 생성자 
			{
				Name = n;                      // 인스턴스 필드에 값 할당 
				Population = Population + 1;   // 정적 필드값 1 증가 
			}
		}

		static void Main()
		{
			Dog p1 = new Dog("Luda");
			Dog p2 = new Dog("Mori");

			Console.WriteLine(p1.Name);
			Console.WriteLine(p2.Name);

			Console.WriteLine(Dog.Population);   // 2
		}
	}
}
