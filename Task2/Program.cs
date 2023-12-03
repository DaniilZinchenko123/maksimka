namespace Task2
{
    public class Program
    {
        static void Main()
        {
            MathOperations math = new MathOperations();

            int sum1 = math.Add(5, 10);
            Console.WriteLine("Sum of two numbers: " + sum1);

            int[] numbers = { 2, 4, 6, 8 };
            int sum2 = math.Add(numbers);
            Console.WriteLine("Sum of an array of numbers: " + sum2);

            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            int[,] sumMatrix = math.Add(matrix1, matrix2);

            Console.WriteLine("Sum of two matrices:");
            for (int i = 0; i < sumMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sumMatrix.GetLength(1); j++)
                {
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}