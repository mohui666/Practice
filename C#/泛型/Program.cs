using System;

namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            // ClassA<int> classA = new ClassA<int>(1,2);
            // Console.WriteLine(classA.GetSum());

            Program p = new Program();
            Console.WriteLine(p.ToString());

            Student s = new Student("张三", 20);
            Console.WriteLine(s.ToString());
        }
    }

    class ClassA<T>
    {
        private T a;
        private T b;
        public ClassA(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public T GetSum()
        {
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic sum = num1 + num2;
            return (T)sum;
        }
    }

    class Student
    {
        private string name;
        private int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return name + "," + age;
        }
    }
}