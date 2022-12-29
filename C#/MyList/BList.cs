using System;

namespace MyList
{
    class BList<T>
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
            Console.WriteLine();
        }
    
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > count - 1)
                {
                    throw new ArgumentOutOfRangeException("Index was out of range. Must be non-negative and less than the size of the collection.");
                }
                return data[index];
            }
            set
            {
                if (index < 0 || index > count - 1)
                {
                    throw new ArgumentOutOfRangeException("Index was out of range. Must be non-negative and less than the size of the collection.");
                }
                data[index] = value;
            }
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("Index was out of range. Must be non-negative and less than the size of the collection.");
            }
            if (data.Length == count)
            {
                T[] temp = new T[count * 2];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            for (int i = count; i > index; i--)
            {
                data[i] = data[i - 1];
            }
            data[index] = item;
            count++;
        }
    
        public int IndexOf(T item)
        {
            for(int index = 0;index < count;index++)
            {
                if(data[index].Equals(item))
                {
                    return index;
                }
            }
            return -1;
        }

        public int LastIndexOf(T item)
        {
            for(int index = count - 1;index > -1;index--)
            {
                if(data[index].Equals(item))
                {
                    return index;
                }
            }
            return -1;
        }
    
        public void Sort()
        {
            
        }
    }
}