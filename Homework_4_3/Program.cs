using System;

namespace Homework_4_3
{
    class Program
    {
        private static void arithmeticProgression(ref double[,] arr, int maxRow, int maxCol)
        {
            int number = 0;
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    arr[i, j] = ++number;
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int maxRow = 4;
            int maxCol = 4;
            double[,] arr = new double[maxRow, maxCol];
            
            arithmeticProgression(ref arr, maxRow, maxCol);


            Console.Read();
        }
    }
}
