using System;

namespace Revision_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NewArray();

        }
        public static void NewArray()
        {
            Random random = new Random();

            Console.Write("Enter row length: ");
            int firstInput = int.Parse(Console.ReadLine());

            Console.Write("Enter column length: ");
            int secondInput = int.Parse(Console.ReadLine());

            int[][] array = new int[firstInput][];
            for (int i = 0; i < firstInput; i++)
            {
                array[i] = new int[secondInput];
                for (int j = 0; j < secondInput; j++)
                {
                    array[i][j] = random.Next(1, 5);
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            int diagonalSum = 0;
            for (int i = 0; i < firstInput && i < secondInput; i++)
            {
                diagonalSum += array[i][i];
            }
            Console.WriteLine("Diagonal sum: " + diagonalSum);

            int rowSum = 0;
            for (int i = 0; i < firstInput; i++)
            {
                rowSum += array[array[i].Length - 1][i];
            }
            Console.WriteLine($"Row sum : {rowSum}");
            if (diagonalSum > rowSum)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
