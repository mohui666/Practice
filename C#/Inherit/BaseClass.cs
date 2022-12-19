using System;

namespace Inherit
{
    class BaseClass
    {
            public int data1;
            public string data2;
            protected int test;

            public void Function1()
            {
                Console.WriteLine("功能1");
            }
            public void Function2()
            {
                Console.WriteLine("功能2");
            }
            public void Function3()
            {
                Console.WriteLine(data1);
            }
    }
}