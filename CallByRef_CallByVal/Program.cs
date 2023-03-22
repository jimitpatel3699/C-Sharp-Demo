using System.Runtime.CompilerServices;


namespace CallByRef_CallByVal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 20;
            int b = a;
            Console.WriteLine("Call By Value");
            Console.WriteLine($"value of a is {a}");
            Console.WriteLine($"value of b is {b}");
            b = 50;
            Console.WriteLine("changing b's value");
            Console.WriteLine($"value of a is {a}");
            Console.WriteLine($"value of b is {b}");

            Console.WriteLine("Call By Reference");
            int j = 10;
            ref int k = ref j;
            Console.WriteLine($"value of j is {j}");
            Console.WriteLine($"value of k is {k}");
            k = 20;
            Console.WriteLine("changing k's value");
            Console.WriteLine($"value of j is {j}");
            Console.WriteLine($"value of k is {k}");

            int x = 15;
            Console.WriteLine($"value of x {x}");
            UpdateValue(ref x);
            Console.WriteLine($"value of x {x}");

            //string default nature
            Console.WriteLine($"String default nature");
            string na = "jimit";
            string ba = na;
            Console.WriteLine($"str 1 = {na}");
            Console.WriteLine($"str 2= {ba}");
            ba = "patel";
            Console.WriteLine($"str 1 = {na}");
            Console.WriteLine($"str 2= {ba}");
            void UpdateValue(ref int b)
            {
                int y;

                y = b;
                Console.WriteLine($"value of b {b}");
                Console.WriteLine($"value of y {y}");
                b = 30;
                y = b;
                Console.WriteLine($"value of b {b}");
                Console.WriteLine($"value of y {y}");

                y = 80;

                Console.WriteLine($"value of y {y}");
                Console.WriteLine($"value of b {b}");
            }


            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "James";
            UpdateName(ref Emp1);
            if(Emp1==null)
            {
                Console.WriteLine($"Emp1 is null");
            }
            else
            {
                Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            }
            
            Console.ReadKey();
        
           void UpdateName(ref Employee Emp2)
            {
                Console.WriteLine($"Emp2 Name = {Emp2.Name}");
                Emp2 = null;
                Console.WriteLine($"Emp2 Null");
            }


          



        }
     }

    public class Employee
    {
        public int EmployeeID;
        public string Name;
    }

}