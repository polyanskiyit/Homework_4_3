using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_3
{
    class Program
    {

        private static void arithmeticProgression(ref double[,] arr, int maxRow, int maxCol, int number)
        {

            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    arr[i, j] = ++number;
                    Console.Write(+arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            int maxRow = 4;
            int maxCol = 4;
            int number = 0;
            double[,] arr = new double[maxRow, maxCol];
            
            arithmeticProgression(ref arr, maxRow, maxCol, number);


            Console.Read();
        }
    }
}
