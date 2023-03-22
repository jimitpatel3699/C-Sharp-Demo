using System.Runtime.CompilerServices;

namespace Methods_Parametrs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            methods_Parametrs obj1 = new methods_Parametrs();
            obj1.DefaultPara();
            obj1.DefaultPara(100, 200);
            obj1.namedpara(23, 21);
            obj1.namedpara(a: 200, b: 900);
            obj1.namedpara(b: 300, a: 100);
            int a = 90;
            int b = 80;
            obj1.refpara(ref a,ref b);
            int c=90;
            int d=80;
            obj1.outpara(out c,out d);
            obj1.dynamicpara("hello");
            obj1.dynamicpara(30);
            int[] aa = {1,2,3,4};
            
            obj1.paramspara(aa);

        }

 
    }

    class methods_Parametrs
    {
        public void DefaultPara(int a = 10, int b = 20)
        {
            Console.WriteLine($"{a + b}");
        }

        public void namedpara(int a, int b)
        {
            Console.WriteLine($"{a + b}");
        }

        public void refpara(ref int a, ref int b)
        {
            Console.WriteLine($"{a + b}");
            Console.WriteLine($"{a}");
        }

        public void outpara(out int a, out int b)
        {
            a = 30;
            b = 40;
            Console.WriteLine($"{a + b}");
        }

        public void dynamicpara(dynamic val)
        {
            Console.WriteLine($"{val}");
        }

        public void valuepara()
        {

        }

        public void paramspara( int[] b,params int[] a)
        {

        }
    }
}
