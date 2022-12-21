using System;

namespace AbstractAndSealed
{
    class Child : Base
    {
        public sealed override void Move()
        {
            //密封类只能用于继承类
        }
    }
}