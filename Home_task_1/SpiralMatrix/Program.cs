namespace SpiralMatrix
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Spiral clockwise matrix:");
            Func(m, n);

            Console.WriteLine("Counter-clockwise spiral matrix:");
            Func_2(m, n);
        }

        public static void Func(int m, int n)
        {
            int[,] a = new int[m, n];
            int printValue = 1;
            int k1 = 0, k2 = m - 1;
            int c1 = 0, c2 = n - 1;
            while (printValue <= m * n)
            {
                //Right Direction Move  
                for (int j = c1; j <= c2; j++)
                {
                    a[k1, j] = printValue++;
                }
                //Down Direction Move  
                for (int i = k1 + 1; i <= k2; i++)
                {
                    a[i, c2] = printValue++;
                }
                //Left Direction Move  
                for (int j = c2 - 1; j >= c1; j--)
                {
                    a[k2, j] = printValue++;
                }
                //Up Direction Move  
                for (int i = k2 - 1; i >= k1 + 1; i--)
                {
                    a[i, c1] = printValue++;
                }
                k1++;
                c1++;
                c2--;
                k2--;
            }

            Print(m, n, a);
        }

        public static void Func_2(int m, int n)
        {
            int[,] b = new int[m, n];
            int printValue = 1;
            int k1 = 0, k2 = m - 1;
            int c1 = 0, c2 = n - 1;

            while (printValue <= m * n)
            {
                //Down Direction Move  
                for (int i = k1; i <= k2; i++)
                {
                    b[i, c1] = printValue++;
                }
                //Right Direction Move  
                for (int j = c1 + 1; j <= c2; j++)
                {
                    b[k2, j] = printValue++;
                }
                //Up Direction Move  
                for (int i = k2 - 1; i >= k1; i--)
                {
                    b[i, c2] = printValue++;
                }
                //Left Direction Move  
                for (int j = c2 - 1; j >= c1 + 1; j--)
                {
                    b[k1, j] = printValue++;
                }
                k1++;
                c1++;
                c2--;
                k2--;
            }
            Print(m, n, b);
        }

        static void Print(int m, int n, int[,] matrix)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}