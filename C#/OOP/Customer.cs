using System;

namespace OOP
{
    class Customer
    {
        public string name;
        public int age;
        public Customer()
        {
            Console.WriteLine("我是妈妈");
        }

        public Customer(string arg1,int arg2)
        {
            name = arg1;
            age = arg2;
        }
        public void Show()
        {
            Console.WriteLine("名字" + name);
            Console.WriteLine("年龄" + age);
        }
    }
}
