using System;
using System.Collections.Generic;

namespace 列表
{
    class Program
    {

        static void Main(string[] args)
        {
            // List<int> list1 = new List<int>(50);
            // Console.WriteLine(list1.Capacity);

            List<int> list2 = new List<int>(){1,1,4,5,1,4};

            // list2.Add(114514);

            // Console.WriteLine(list2.Count +" "+ list2.Capacity);
            // Console.WriteLine(list2[6]);
            // list2[3] = 10;
            // ShowList(list2);

            // list2.Insert(2,114514);
            // ShowList(list2);

            // list2.Remove(1);
            // ShowList(list2);

            // list2.RemoveAt(2);
            // ShowList(list2);

            Console.WriteLine(list2.IndexOf(1));
            Console.WriteLine(list2.LastIndexOf(1));

            list2.Sort();
            ShowList(list2);
        }

        static void ShowList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}