using System;

namespace Inherit
{
    class DerivedClass : BaseClass
    {
        public DerivedClass(int data1)
        {
            this.data1 = data1;
        }

        public void Test()
        {
            base.test = 100;
            Console.WriteLine(test);
        }
    }
}