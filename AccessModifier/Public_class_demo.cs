namespace AccessModifier
{
    internal class Public_class_demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Demo1 obj1 = new Demo1();
            obj1.public_method();
            //obj1.private_protected_method();
            obj1.protected_internal_method();
            obj1.internal_method();
            // obj1.protected_method();
            //obj1.private_method();

        }
    }

    public class Demo1
    {
       
        public void public_method()
        {
            Console.WriteLine("hello from Demo1 public_method");
        }

        private protected void private_protected_method()
        {
            Console.WriteLine("hello from Demo1 class private_protected_method");
        }

        protected internal void protected_internal_method()
        {
            Console.WriteLine("hello from Demo1 class protected_internal_method");
        }

        internal void internal_method()
        {
            Console.WriteLine("hello from Demo1 class internal_method");
        }

        protected void protected_method()
        {
            Console.WriteLine("hello from Demo1 class protected_method");
        }

        private void private_method()
        {
            Console.WriteLine("hello from Demo1 class private_method");
        }
    }

    public class Derived_class : Demo1
    {
        public void Derived_class_method()
        {
            public_method();
            private_protected_method();
            protected_internal_method();
            internal_method();
            protected_method();
            //private_method();

        }
    }

    public class Other_nonderived_class
    {
        public void nonderivedclass_method()
        {
        
        }

       
    }
}