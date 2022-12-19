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
            
            DerivedClass dc1 = new DerivedClass(6324);
            dc1.Function1();
            dc1.Function3();
            dc1.Test();

            DerivedClass dc2 = new DerivedClass(6324);
            dc2.Test();
        }
    }
}