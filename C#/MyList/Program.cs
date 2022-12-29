using System;

namespace MyList;
class Program
{
    static void Main(string[] args)
    {
        BList<int> list = new BList<int>();
        list.Add(100);
        list.Add(200);
        list.Add(300);
        list.Add(100);
        list.Add(200);
        list.Show();
        // Console.WriteLine(list[1]);
        list[1] = 500;
        // Console.WriteLine(list[1]);
        list.Insert(1, 1000);
        list.Insert(1, 1000);
        list.Insert(1, 1000);
        list.Insert(1, 1000);
        list.Show();
        // Console.WriteLine(list.Capacity);
        // Console.WriteLine(list.IndexOf(100));
        // Console.WriteLine(list.LastIndexOf(100));
        list.Sort();
        list.Show();
    }
}
