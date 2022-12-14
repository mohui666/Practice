using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for(int i = 0;i < strArray.Length;i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }

            //冒泡排序
            bool isChange = false;
            for(int j = 0;j<intArray.Length-1;j++)
            {
                for (int i = 0; i < intArray.Length - j - 1; i++)
                {
                    // 如果元素需要交换，则交换它们
                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[i + 1];
                        intArray[i + 1] = temp;
                        isChange = true;
                        // foreach(int temp1 in intArray)
                        // {
                        //     Console.Write(temp1 + " ");
                        // }

                        //Console.Write('\n');
                    }
                    if(!isChange)
                    {
                        break;
                    }
                }
            }

            foreach(int temp in intArray)
            {
                Console.Write(temp + " ");
            }
        }
    }
}
