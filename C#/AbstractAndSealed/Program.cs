using System;

namespace AbstractAndSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy DaoLi = new Boss();
            DaoLi.Attack();
        }
    }
}
