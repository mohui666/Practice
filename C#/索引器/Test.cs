using System;

namespace 索引器
{
    class Test
    {
        private string[] name = new string[10];
        public string this[int index]
        {
            get 
            {
                return name[index];
            }
            set 
            {
                name[index] = value;
            }
        }
        // public int this[int index]
        // {
        //     get 
        //     {
        //         Console.WriteLine(index);
        //         return 0;
        //     }
        //     set 
        //     {
        //         Console.WriteLine(index); 
        //         Console.WriteLine(value);
        //     }
        // }
    }
}