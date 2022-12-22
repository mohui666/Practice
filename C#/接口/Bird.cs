using System;

namespace 接口
{
    class Bird : IFly
    {
        public void Fly()
        {
            Console.WriteLine("小鸟飞翔");
        }

        public void FlyGenshin()
        {
            Console.WriteLine("小鸟玩原神");
        }
    }
}