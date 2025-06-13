using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("Parent()");
            }
            public Parent(String name)
            {
                Console.WriteLine("Parent(string name)");
            }
            public Parent(int param)
            {
                Console.WriteLine("Parent(int param)");
            }
            public Parent(double param)
            {
                Console.WriteLine("Parent(double param)");
            }
        }

         class Child : Parent
        {
            public Child() : base("child")
            {
                Console.WriteLine("자식 생성자");
            }

            public Child(string name) : base(name)
            {
                Console.WriteLine("Child(string name)");
            }

            public Child(int param) : base(param)
            {
                Console.WriteLine("Child(int param)");
            }

            public Child(double param) : base(param)
            {
                Console.WriteLine("Child(double param)");
            }
        }

        static void Main(string[] args)
        {
            Child childA = new Child("abc");
            Child childB = new Child(3);
            // int(4) < long(8) < float(4) < double(8) 
        }

    }
}
