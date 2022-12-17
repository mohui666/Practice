using System;

namespace Error
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6};
            try
            {
                Console.WriteLine(array[7]);
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.WriteLine("System.IndexOutOfRangeException");
            }
            finally
            {
                Console.WriteLine("DDD");
            }
        }
    }
}