using System;

namespace Virtual
{
    class Boss : Enemy
    {
        public override void Move()
        {
            Console.WriteLine("Boss");
        }

        public new void Attack()
        {
            Console.WriteLine("攻击");
        }
    }
}