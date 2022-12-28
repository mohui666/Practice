using System;

namespace 索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            // t[9] = 100;

            t[3] = "说的道理";
            Console.WriteLine(t[3]);
        }
    }
}