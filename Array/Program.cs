using System;


namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); 
            int n;
            Console.WriteLine($"Enter size of an Array");
            n=Int32.Parse(Console.ReadLine());
            int[] arr1=new int[n];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine($"Enter arr1 [{i}] :");
                arr1[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine($"Array Items");
            //foreach (int i in arr1)
            //{
            //    console.writeline($"arr1[{i}] : {arr1[i]}");
            //}
            for (int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine($"arr1[{i}] : {arr1[i]}");
            }
            Console.WriteLine($"Array length : {arr1.Length}");
            Console.WriteLine($"sort array");
            Array.Sort(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"arr1[{i}] : {arr1[i]}");
            }
            Console.WriteLine($"reverse array");
            Array.Reverse(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"arr1[{i}] : {arr1[i]}");
            }
            
            Console.WriteLine($"{Array.IndexOf(arr1, 1)}");
            Console.WriteLine($"Get length @ [0] :{arr1.GetLength(0)}");
            //Console.WriteLine($"Get length @ [1] :{arr1.GetLength(1)}");

            int k = 0;
            int j = 0;
            int[,] X;

            X = new int[2, 3];

            Console.Write("Enter Elements : \n");
            for (k = 0; k < X.GetLength(0); k++)
            {
                for (j = 0; j < X.GetLength(1); j++)
                {
                    Console.Write("\tElement[" + k + "," + j + "]: ");
                    X[k, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\n\nElements are: \n");
            for (k = 0; k < X.GetLength(0); k++)
            {
                for (j = 0; j < X.GetLength(1); j++)
                {
                    Console.Write(X[k, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Get length @[0] :{X.GetLength(0)}");
            Console.WriteLine($"Get length @ [1]:{X.GetLength(1)}");
            Console.WriteLine($"Array length : {X.Length}");

            //implicit typed array
            var Arr2 = new[] { 12, 13, 12, 'a' };
            Console.WriteLine(Arr2[3]);
        }
    }
}