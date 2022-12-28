using System;

namespace MyList;
class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();
        list.Add(100);
        list.Add(200);
        list.Add(300);
        list.Add(100);
        list.Add(200);
        list.Show();
    }
}
