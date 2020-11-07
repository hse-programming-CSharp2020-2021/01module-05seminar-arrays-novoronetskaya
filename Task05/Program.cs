using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 1.
 * В программе сформировать целочисленный массив,
 * содержащий N первых элементов последовательности Фибоначчи:
 * A[0] = 1, A[1] = 1, A[2] = A[0] + A[1], … A[K] = A[K-1] + A[K-2], …
 * 
 * Формирование массива организовать при помощи метода.
 * Элементы массива вывести на экран в обратном порядке.
 * Методы класса Array НЕ использовать.
 *
 * Пример входных данных:
 * 5
 *
 * Пример выходных данных:
 * 5 3 2 1 1
 */

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask05();
        }

        public static void RunTask05()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            FillArray(ref array, array.Length);
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
        }
        public static void FillArray(ref int[] array, int length)
        {
            for (int i = length - 1; i >= 0; i--)
            {
                if (i >= length - 2)
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] = array[i + 1] + array[i + 2];
                }
            }
        }
    }
}