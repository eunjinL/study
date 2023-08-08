using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class accessibility
    {
        class Class1 { }        // Class1 is internal - 노출 안됨
        public class Class2 { } // Class2 - 자기가 속한 어셈블리 밖에서도 노출 됨
        class ClassA
        {
            int x;              // x is private - 어셈블리의 다른 형식에 오픈 안됨 
        }

        class ClassB
        {
            internal int x;     // x can be accessed from other types in same assembly
        }

        class BaseClass
        {
            void Foo() { }    // Foo is private - SubClass의 값들은 이걸 못씀
            protected void Bar() { }    // Foo is accessible to subclasses
        }

        class Subclass : BaseClass
        {
            void Test1() { Foo(); }     // Error 
            void Test2() { Bar(); }     // OK
        }

        static void Main() { }
    }
}
