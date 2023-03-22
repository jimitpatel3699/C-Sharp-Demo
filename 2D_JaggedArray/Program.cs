namespace _2D_JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0]= new int[4];
            arr[1]= new int[3];
            arr[2]= new int[4]; 
            arr[3]= new int[5];


            Console.WriteLine($"Array row lenth {arr.GetLength(0)}");
            //Console.WriteLine($"Array col length{arr.GetLength(1)}");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int num = 10;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    num++;
                    arr[i][j] = num;
                }
               
            }
            //Printing the values of Jagged array by using foreach loop within for loop
            Console.WriteLine("\n\nPrinting the Values of Jagged Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                foreach (int x in arr[i])
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"arr[0][1] {arr[0][1]}");
            Console.WriteLine($"arr[2][1] {arr[2][1]}");
            Console.WriteLine($"arr[0] {arr[0]}");
            Console.WriteLine($"arr[1] {arr[0]}");
            Console.WriteLine($"arr length {arr.Length}");

            //Console.WriteLine(arr[0,1]);
        }
    }
}