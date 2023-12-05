/* Задача 2: Задайте двумерный массив. Напишите программу, которая 
поменяет местами первую и последнюю строку массива. */

using System;
namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {

        var array = new int[4, 4]
            { { 1, 2, 3, 4 },
              { 5, 6, 7, 8 },
              { 9, 10, 11, 12 },
              { 13, 14, 15, 16 }
            };
            for(int i = 0; i < array.GetLength(1); i++)
            {
                var tmp = array[3, i];
                array[3, i] = array[0, i];
                array[0, i] = tmp;
            }
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}