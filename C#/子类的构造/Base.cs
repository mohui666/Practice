using System;

namespace 子类的构造
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("基类的构造");
        }

        public Base(int a,int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}