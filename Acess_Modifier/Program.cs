namespace Acess_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Example obj1 = new Example();
            int a = obj1.c;
            obj1.a = 100;

        }

       
       
           
    }

    public class Example
    {
        public int a;//public sope
        int b;//privae scope
        private int c=100;//private scope

    }
    internal class Example2
    {
        public int a = 100;
        
    }
    //t b = a;

    private class ex3
    {
        public int a;
    }
}