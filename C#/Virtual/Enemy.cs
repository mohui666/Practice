using System;

namespace Virtual
{
    class Enemy
    {
        public virtual void Move()
        {
            Console.WriteLine("移动");
        }
    }
}