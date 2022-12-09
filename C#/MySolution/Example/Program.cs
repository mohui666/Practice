using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //成绩分层
            //Console.Write("Input your grade(0~100):");
            //int grade = Convert.ToInt32(Console.ReadLine());
            //if (grade >= 90 && grade <= 100)
            //{
            //    Console.WriteLine("Your got A!");
            //}
            //else if (grade >= 70 && grade < 90)
            //{
            //    Console.WriteLine("Your got B!");
            //}
            //else if (grade >= 60 && grade < 70)
            //{
            //    Console.WriteLine("Your got C!");
            //}
            //else if (grade < 60 && grade >= 0)
            //{
            //    Console.WriteLine("Your got D!");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //判断是否是闰年
            //Console.Write("Input a year:");
            //int year = Convert.ToInt32(Console.ReadLine());
            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //{
            //    Console.WriteLine(year + " is a leap year");
            //}
            //else
            //{
            //    Console.WriteLine(year + " isn't a leap year");
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            //   *
            //  *
            // *
            //*
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            //示例
            //****
            // ****
            //  ****
            //   ****
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int x = 0; x < n; x++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}

            //示例
            //   *
            //  **
            // ***
            //****
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= i - 2;j++) 
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= 2*i - 3; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}

            //计算公约数
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int min = num1;
            if (num2<min) 
            {
               num2 = min;
            }

            for (int i = min;i > 0;i++) 
            {
               if (i % num1 == 0 && i % num2 == 0)
               {
                   Console.WriteLine(i);
               }
            }
        }
    }
}
