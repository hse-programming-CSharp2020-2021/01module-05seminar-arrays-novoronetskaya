﻿using System;

/*
 * Написать метод замены всех вхождений максимального элемента массива значением, переданным в параметре.​
 *
 * В основной программе объявить и инициализировать массив
 * (данные вводятся с клавиатуры: сначала количество элементов, далее сам массив поэлементно с новой строки);
 * Из последней введенной строки получить от пользователя число,
 * заменить им все вхождения максимального элемента в массив.
 * 
 * Исходный и изменённый массивы вывести на экран.​
 *
 * Дополнительные указания смотрите непосредственно в коде
 *
 * Пример входных данных:
 * 5
 * 4
 * 7
 * 3
 * 2
 * 4
 * 10
 *
 * Пример выходных данных:
 * 4 7 3 2 4
 * 4 10 3 2 4
 */

namespace Task01
{
    class Program
    {
        static void Main()
        {
            RunTask01();
        }

        public static void RunTask01()
        {
            int numOfItems = int.Parse(Console.ReadLine());

            int[] array = new int[numOfItems];
            int.TryParse(Console.ReadLine(), out array[0]);
            int max = array[0];
            for (int i = 1; i < numOfItems; i++)
            {
                int.TryParse(Console.ReadLine(), out array[i]);
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int newValue = int.Parse(Console.ReadLine());
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
            ReplaceMaxElem(ref array, newValue);
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
        }

        static void ReplaceMaxElem(ref int[] arr, int val)
        {
            int max = arr[0];
            foreach (int element in arr)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    arr[i] = val;
                }
            }
        }
    }
}