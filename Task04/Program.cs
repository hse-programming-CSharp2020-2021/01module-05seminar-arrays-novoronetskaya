using System;

/*
 * Пользователем с клавиатуры вводятся целые числа N > 1, A и D.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов.
 * Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D.
 * Формирование массива организовать при помощи метода.​
 *
 * Пример входных данных:
 * 5
 * 3
 * 4
 *
 * Пример выходных данных:
 * 3 7 11 15 19
 */

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask04();
        }

        public static void RunTask04()
        {
            int N = int.Parse(Console.ReadLine());

            long A, D;
            A = long.Parse(Console.ReadLine());
            D = long.Parse(Console.ReadLine());
            long[] array = new long[N];
            array[0] = A;
            FillArray(ref array, D);
            foreach (long element in array)
            {
                Console.Write($"{element} ");
            }
        }

        static void FillArray(ref long[] array, long D)
        {
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = array[i - 1] + D;
            }
        }
    }
}