namespace MatrixMultiplication
{
    using System;

    public class MatrixMultiplication
    {
        public static void Main(string[] args)
        {
            var firstMatrix = new double[,] { { 1, 3 }, { 5, 7 } };
            var secondMatrix = new double[,] { { 4, 2 }, { 1, 5 } };
            var product = MultiplyMatrices(firstMatrix, secondMatrix);

            for (int row = 0; row < product.GetLength(0); row++)
            {
                for (int col = 0; col < product.GetLength(1); col++)
                {
                    Console.Write(product[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static double[,] MultiplyMatrices(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new ArgumentException("The columns of the first matrix should be equal to the rows of the second matrix");
            }

            var lengthOfFirstMatrix = firstMatrix.GetLength(1);
            var product = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int i = 0; i < product.GetLength(0); i++)
            {
                for (int j = 0; j < product.GetLength(1); j++)
                {
                    for (int k = 0; k < lengthOfFirstMatrix; k++)
                    {
                        product[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }                        
                }                    
            }
                
            return product;
        }
    }
}