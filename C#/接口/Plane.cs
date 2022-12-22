using System;

namespace 接口
{
    class Plane : IFly
    {

        public void Fly()
        {
            Console.WriteLine("开飞机");
        }

        public void FlyGenshin()
        {
            Console.WriteLine("玩原神开飞机");
        }
    }
}