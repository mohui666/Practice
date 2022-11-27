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
            Console.Write("Input a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " isn't a leap year");
            }
        }
    }
}
