using System;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //多态
            IFly fly;
            fly = new Plane();
            fly.FlyGenshin();

            fly = new Bird();
            fly.FlyGenshin();
        }
    }
}
