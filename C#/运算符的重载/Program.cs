using System;

namespace 运算符的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("张三", 18, 0001);
            Student s2 = new Student("张三", 18, 0001);
            Student s3 = s1;

            Console.WriteLine(s1 == s2); // True
            Console.WriteLine(s1 == s3); // True
        }
    }
}