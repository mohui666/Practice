using System;

namespace AbstractAndSealed
{
    class Boss : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("重写的Boss攻击");
        }
    }
}