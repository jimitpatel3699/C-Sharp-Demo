namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Enter Number 1: ");
            int no1=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Number 2: ");
            int no2=int.Parse(Console.ReadLine());
            try
            {
                int ans = no1 / no2;
                Console.WriteLine($"Division of no1/no2={ans} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"Help link: {ex.HelpLink}");
                Console.WriteLine($"stack tace:{ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine($"Finally Block  executed");
            }
            
            
        }
    }
}