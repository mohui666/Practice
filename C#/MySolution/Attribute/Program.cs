namespace Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer Lisa = new Customer();

            var num = 123;
            Console.WriteLine(num);
            Lisa.Age = 120;
            Lisa.Name = "Lisa";
            Console.WriteLine(Lisa.Age);
            Console.WriteLine(Lisa.Name);
        }
    }
}