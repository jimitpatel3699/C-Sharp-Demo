namespace Fields_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Test obj1 = new Test();
            Console.WriteLine($"default value {obj1.Month}");
            Console.WriteLine($"default value {obj1.returnmonth()}");
            obj1.Month = 12;
            Console.WriteLine($"value after set {obj1.Month}");
            obj1.returnmonth();
        }
    }


    public class Test
    {
        int month;
        public Test()
        {
            month = 1;
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int returnmonth()
        {
            return month;
        }
    }
}