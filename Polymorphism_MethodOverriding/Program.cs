namespace Polymorphism_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           ClassChild obj1 = new ClassChild();
            obj1.Show();
            obj1.Show1();
            ClassChild obj2 = new ClassChild();
            obj2.Show();
            ClassParent obj3 = new ClassChild();
            obj3.Show();
            obj3.Show1();
        }
    }

    public class ClassParent
    {
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
        public void Show1()
        {
            
            Console.WriteLine("Parent Class Show1 Method");
        }
    }
    public class ClassChild : ClassParent
    {
        //Overriding Method
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
        public new void Show1()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show1 Method");
        }
    }
    

}

    