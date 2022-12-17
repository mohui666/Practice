using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer player1 = new Customer();
            // player1.name = "邓公";
            // player1.age = 3;
            // Customer player2 = new Customer();
            // player2.name = "牛子";
            // player2.age = 18;
            // player1.Show();
            // player2.Show();

            // Vector3 v1 = new Vector3();
            // v1.SetX(2.5f);
            // v1.SetY(2.5f);
            // v1.SetZ(2.5f);
            // Console.WriteLine(v1.Length());

            Customer JiangZeMin = new Customer("蛤蟆",18);
            JiangZeMin.Show();
        }
    }
}