using DllDemo;
namespace Assemblies
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Nullable<int> a = null;
            string name = null;
            int? i = null;
            Console.WriteLine(i.GetValueOrDefault());
        }
    }
}