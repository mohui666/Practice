using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(F(12));
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(n));
            // string str = Console.ReadLine();
            // int[] intArray = StringToInt(str);
            // int m = intArray[0];
            // int n = intArray[1];
            
            // for(int i = m;i <n+1;i++)
            // {
            //     if(PrimeNum(i)!=0)
            //     {
            //         if(PrimeNum(AntiNum(PrimeNum(i)))!=0)
            //         {
            //             Console.Write(i + " ");
            //         }
            //     }
            // }
        }
        static void Add(params int[] array)
        {

        }

        static void Username(string username)
        {
            Console.WriteLine(username);
        }

        static bool Verify()
        {
            return true;
        }
        
        static int AntiNum(int a)
        {
            int temp = a;
            int number = 0;
            while(temp%10!=0/*||temp/10!=0*/)
            {
                number = number * 10 + temp % 10;
                temp /= 10;
            }
            return number;
        }
    
        static int PrimeNum(int i)
        {
            bool isPrime = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                return i;
            }
            else
            {
                return 0;
            }
        }

        static int[] StringToInt(string str)
        {
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }
            return intArray;
        }
        
        static void Test()
        {
            Console.Write("嘉然");
            Test();
            Console.Write("向晚");
        }

        static int F(int n)
        {
            if(n == 0)
            {
                return 2;
            }
            if(n == 1)
            {
                return 3;
            }
            int res = F(n - 1) + F(n - 2);
            return res;
        }
        
        static int Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            if(n == 1)
            {
                return 1;
            }
            return n*Factorial(n-1);
        }
    }
}

