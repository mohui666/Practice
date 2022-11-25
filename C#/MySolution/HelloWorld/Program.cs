using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); //换行输出
            //Console.Write("Hello ");//不换行输出
            //Console.Write("World!\n");
            
            //输入
            //String str = Console.ReadLine();
            //Console.WriteLine(str);

            String str = Console.ReadLine();
            int strInt = Convert.ToInt32(str);

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strInt + a);
        }
    }
}
