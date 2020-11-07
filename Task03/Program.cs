using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 0.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов,
 * элементами которого являются нечетные числа от 1.
 * Заполнение массива нечётными числами организовать при помощи метода.​
 *
 * Пример входных данных:
 * 7
 *
 * Пример выходных данных:
 * 1 3 5 7 9 11 13
 */

namespace Task03
{
    class Program
    {
        static void Main()
        {
            RunTask03();
        }

        public static void RunTask03()
        {
            int N = int.Parse(Console.ReadLine());
            ulong[] array = new ulong[N];
            FillArray(ref array);
            foreach (ulong element in array)
            {
                Console.Write($"{element} ");
            }
        }

        static void FillArray(ref ulong[] array)
        {
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = array[i - 1] + 2;
            }
        }
    }
}
