using System.Security.Cryptography;

namespace Interface
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Child C1 = new Child();
            C1.Add(12, 12);
        }
        

    }

    class Child : ITestInterface
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
    }
}