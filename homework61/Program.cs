//Найти произведение двух матриц.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = CheckInputIsNumber("Введите число строк первой матрицы (m): ");
            int n = CheckInputIsNumber("Введите число столбцов первой матрицы (n): ");
            int[,] arrayOne = new int[m, n];
            int a = CheckInputIsNumber("Введите число строк второй матрицы (a) ");
            int b = CheckInputIsNumber("Введите число столбцов второй матрицы (b): ");
            int[,] arrayTwo = new int[a, b];
            int[,] arrayResult = new int[m, b];


            if (m != a)
                Console.WriteLine("Умножение невозможно,т.к. число столбцов первой матрицы не равно числу строк второй матрицы");
            else
            {
                FillArrayNK(arrayOne);
                PrintArray(arrayOne);
                FillArrayAB(arrayTwo);
                PrintArray(arrayTwo);
                CompositionArray(arrayResult, arrayOne, arrayTwo);
                PrintArray(arrayResult);
            }
        }

        private static void PrintArray(int[,] array)
        {
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                    Console.Write($"{array[y, x]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void FillArrayNK(int[,] array2)
        {
            Random rnd = new Random();
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = rnd.Next(1, 100);
                }
            }
        }

        private static void FillArrayAB(int[,] array2)
        {
            Random rnd = new Random();
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = rnd.Next(1, 100);
                }
            }
        }

        private static void CompositionArray(int[,] arrayResult, int[,] arrayOne, int[,] arrayTwo)
        {
            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwo.GetLength(1); j++)
                {
                    for (int n = 0; n < arrayTwo.GetLength(0); n++)

                        arrayResult[i, j] += arrayOne[i, n] * arrayTwo[n, j];
                }
            }
        }

        private static int CheckInputIsNumber(string text)
        {
            int number;
            Console.WriteLine(text);
            string input = Console.ReadLine();
            bool isNum = int.TryParse(input, out number);

            while (!isNum)
            {
                Console.WriteLine("Вы ввели не целое число! Попробуйте ещё раз: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out number);
            }

            return number;
        }
    }
}







