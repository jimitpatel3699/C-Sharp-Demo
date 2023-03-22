using System.ComponentModel;
using System.Globalization;

namespace Constructor
{
    class construct
    {
        public int i;
        string name;
        public construct(int a, int b)
        {
            //explicit constructor overloading;
            Console.WriteLine($"{a + b}");
        }
        public construct(int a, int b, int c)
        {
            //explicit constructor overloading;
            Console.WriteLine($"{a + b + c}");
        }

        public void setval()
        {
            Console.WriteLine($"value of  i is {i}");
        }

    }
    internal class Program
    {

        private Program()
        {
            Console.WriteLine("private constructor called");
        }
        
        static void Main(string[] args)
        {
            Program m1 = new Program();
            Console.WriteLine("Hello, World!");

            //instance of class which have overload constructor
            construct conobj1 = new construct(10, 20, 40);
            //int a = conobj1.i;
            conobj1.setval();

            //instance of class which have copy constructor
            copy_constructor obj4 = new copy_constructor(10, 20);
            copy_constructor obj5 = new copy_constructor(obj4);

            //instance of class which have static constructor
            staticconstruc obj3 = new staticconstruc(100, 101);
            //Console.WriteLine(obj3.i);//not allowed because i as static in class
            Console.WriteLine($"difference bet static and normal constuctor static only invoke once here static constructor not invoke again");
            staticconstruc obj6 = new staticconstruc(200, 201);

            //privateconstructor obj1 = new privateconstructor();
            //above sentence not allowed due to it's protection level because we use private constructor inside class
            Console.WriteLine($"value called from private class {private_constructor.k}");

            //instance of class which have both type constructor public + private
            Console.WriteLine($"class instance create in main class");
            public_and_private obj7 = new public_and_private(100, 200);

        }
    }

    //copy constructor
    class copy_constructor
    {
        int x;
        int y;
        public copy_constructor(int x, int y)
        {
            Console.WriteLine($"normal constructor called");
            this.x = x;
            this.y = y;
        }
        public copy_constructor(copy_constructor obj)
        {
            Console.WriteLine($"copy constructor called");
            this.x = obj.x;
        }
    }

    //static constructor
    class staticconstruc
        {
        static public int i;
        public int j;
        static staticconstruc() //static staticconstruc(int i) not allowed because staic constructor not take any arguments
        {
            i = 0;
            //j = 1; not [ossible only allowed static member intialization
            Console.WriteLine($"value of  i is in static constuctor {i}");
        }
        public staticconstruc(int k, int m)
        {
            i = k;
            j =m;
            Console.WriteLine($"value of  i is in public constructor {i}");
            Console.WriteLine($"value of  j is in public constructor {j}");
        }

    }


    //private constructor
    public class private_constructor
    {
        int i;
        static public int k = 100;

        private private_constructor()
        {
            i = 10;
            Console.WriteLine($"called private constuctor  i= {i}");
        } 

        
        private_constructor obj = new private_constructor();
    }


    //class have both types constructor public + private
    class public_and_private
    {
        int i;
        int j;
        //public_and_private obj8 = new public_and_private(200, 203);
        private public_and_private()
        {
            Console.WriteLine($" private constuctor called ");
        }

        public public_and_private(int i, int j)
        {
            this.i = i;
            this.j = j;
            Console.WriteLine($" public constuctor called");
        }

        

    }   
}