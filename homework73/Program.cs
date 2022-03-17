﻿//  Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int num = Int32.Parse(Console.ReadLine());


            FuncGroup(num);
        }

        private static void FuncGroup(int num)
        {
            int group = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i == Math.Pow(2, group))
                {
                    Console.WriteLine();
                    group++;
                    Console.Write($"Группа {group}: ");
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}


