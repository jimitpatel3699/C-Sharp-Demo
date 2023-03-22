using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;

namespace Mutable_imMutable
{

    

    internal class Program
    {
        public readonly int y = 5;
        static void Main(string[] args)
        {
           
            Program obj1=new Program();

        unsafe
            {
                //int n = 10;
                int n = obj1.y;    
                //int* p = &n;
                string name = "hello";
                Console.WriteLine("Value of the n: " + n);
                Console.WriteLine("address of the n: " + (long)&n);
                //obj1.y = 100;

                Console.WriteLine("Value of the n: " + n);
                Console.WriteLine("address of the n: " + (long)&n);
                //Console.WriteLine("Value of the name: " + name);
                //Console.WriteLine("address of the name: " + (long)&name);


            }


        }
    }
}