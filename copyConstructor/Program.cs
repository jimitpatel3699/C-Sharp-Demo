namespace copyConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.Display();
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.Display();
            Console.ReadKey();
        }
    }
    public class CopyConstructor
    {
        int x;
        int y;

        //Parameterized Constructor
        public CopyConstructor(int i)
        {
            x = i;
            y = 50;
        }

        //Copy Constructor
        public CopyConstructor(CopyConstructor obj)
        {
            y = obj.x;
        }

        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
            Console.WriteLine($"Value of y = {y}");
            Console.WriteLine($"one time method call done");
        }
    }
}


   
