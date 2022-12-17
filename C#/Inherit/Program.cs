using System;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.Function1();
            bc.data1 = 10;
            bc.data2 = "牛子";
            
            DerivedClass dc1 = new DerivedClass();
            dc1.Function1();
            dc1.Function2();
            dc1.data1 = 100;
        }
    }
}