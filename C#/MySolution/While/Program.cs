using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (i < n + 1) 
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //3n+1问题
            int i = Convert.ToInt32(Console.ReadLine());
            while (i != 1)
            {
                if (i % 2 != 0)
                {
                    i = 3 * i + 1;
                }
                else
                {
                    i = i / 2;
                }
                Console.WriteLine(i);
            }
        }
    }
}
