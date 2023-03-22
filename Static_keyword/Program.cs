namespace Static_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          
            //Static_Class obj1 = new Static_Class();
            //obj1.demo1();
            Static_Class.demo1();
        }
    }

     static internal class Static_Class
    {
        static public int a = 100;

        
        public static void demo1()
        {
           
            Console.WriteLine($"value of a is {a}");        
        }
    }

    class Non_static_class
    {
        public int a = 100;
        public static void demo1()
        {
            Non_static_class obj1 = new Non_static_class();
            Console.WriteLine($"value of a is {obj1.a}");
        }
    }
}