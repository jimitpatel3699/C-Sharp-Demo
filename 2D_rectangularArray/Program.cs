namespace _2D_rectangularArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,3];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j= 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter value for a[{i},{j}] :");
                    a[i, j] =  Int32.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]} ");
                    
                }
                Console.WriteLine();
            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}