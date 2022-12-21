using System;

namespace 子类的构造
{
    class Child : Base
    {
        public Child() : base() 
        {
            Console.WriteLine("子类的构造");
        }

        public Child(int a,int b,int c) : base(a,b) 
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}