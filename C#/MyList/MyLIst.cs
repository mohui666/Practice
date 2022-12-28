using System;

namespace MyList
{
    class MyList<T>
    {
        private T[] data = new T[0];
        private int count = 0;
        
        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }

        public void Add(T item)
        {
            if(data.Length == 0)
            {
                data = new T[4];
            }

            if(data.Length == count)
            {
                T[] temp = new T[count * 2];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            data[count] = item;
            count++;
        }

        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(data[i] + " ");
            }
        }
    }
}