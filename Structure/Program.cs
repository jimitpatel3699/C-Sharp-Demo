using System.Security.Cryptography.X509Certificates;

namespace Structure
{
    internal class Program
    {
        enum days { A, B, C, D, E, F }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");
            Employee employee = new Employee();
            Console.WriteLine(employee.a);
            Console.WriteLine(days.F);
            int a = (int)days.A;
            
            Console.WriteLine(a);
        }
    }

    struct Employee
    {
        public int a;
       public Employee()
        {
           a = 0;
        }


    }
}