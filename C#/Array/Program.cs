using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //3个可乐瓶换一个可乐，现在有m个可乐，问一共可以喝多少瓶可乐，剩几个空瓶
            int BottleNum = Convert.ToInt32(Console.ReadLine());
            int UsedNum = BottleNum;
            while(BottleNum > 2)
            {
                UsedNum += BottleNum/3;
                BottleNum = BottleNum/3 + BottleNum%3;
            }
            Console.WriteLine(UsedNum);
            Console.WriteLine(BottleNum);

            //凯撒加密
            // int Key = Convert.ToInt32(Console.ReadLine());
            // String str = Console.ReadLine();
            // char[] strArray = str.ToCharArray();
            // for(int i = 0;i < strArray.Length;i++)
            // {
            //     if((strArray[i] >= 'a'&& strArray[i]<= 'z')||(strArray[i]>= 'A' && strArray[i] <= 'Z'))
            //     {
            //         strArray[i] = (char)(strArray[i] + Key);
            //         if(strArray[i] > 'z' && strArray[i] < 'z'+ Key + 1)
            //         {
            //             strArray[i] = (char)(strArray[i] - 26);
            //         }
            //         if(strArray[i] > 'Z' && strArray[i] < 'Z'+ Key + 1)
            //         {
            //             strArray[i] = (char)(strArray[i] - 26);
            //         }
            //     }
            // }

            // foreach(char temp in strArray)
            // {
            //     Console.Write(temp);
            // }
        }
    }
}
