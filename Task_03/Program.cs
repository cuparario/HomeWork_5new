/* Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов. */

using System;

class Program
{
    static void Main()
    {
        int[,] array = 
        {
            {9, 2, 3, 1},
            {4, 5, 6, 3},
            {7, 1, 1, 5}
        };           

        int minSum = int.MaxValue;
        int minRow = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minRow = i;
            }
        }

        Console.WriteLine($"Строка с минимальной суммой элементов: {minRow}");
    }
    
}          