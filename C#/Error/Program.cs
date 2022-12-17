using System;

namespace Error
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6};
<<<<<<< HEAD
            Console.WriteLine("System.IndexOutOfRangeException");
            Console.WriteLine("System.IndexOutOfRangeException");
            Console.WriteLine("System.IndexOutOfRangeException");
            Console.WriteLine("System.IndexOutOfRangeException");
            Console.WriteLine("System.IndexOutOfRangeException");
            Console.WriteLine("System.IndexOutOfRangeException");
=======
            
>>>>>>> a58cbf12989b72d385189753c6ffef02eb34f313
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
<<<<<<< HEAD
                Console.WriteLine("DDD");
=======
                Console.WriteLine("amma");
>>>>>>> a58cbf12989b72d385189753c6ffef02eb34f313
            }
        }
    }
}