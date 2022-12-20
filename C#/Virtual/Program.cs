using System;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss DaoLi = new Boss();
            DaoLi.Move();
            DaoLi.Attack();

            Enemy Hamood;
            Hamood = new Boss();
            Hamood.Attack();
        }
    }
}
