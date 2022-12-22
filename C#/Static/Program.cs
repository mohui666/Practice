using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Test a = new Test();
            Test b = new Test();
            a.hp = 10;
            Test.speed = 1000;

            Console.WriteLine(Test.speed);
            Console.WriteLine(a.hp);
        }
    }
}