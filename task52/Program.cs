﻿/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int[,] Get2DArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}



void SredArifm(int[,] array)
{
    Console.WriteLine();
    Console.Write("SrAr    ");
    for (int col = 0; col < array.GetLength(1); col++)
    {
        double sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sum = sum + array[row, col];
        }
        Console.Write($"{Math.Round(sum / array.GetLength(0), 1)}\t");
    }
}

int[,] userArray = Get2DArray(3, 5, 0, 10);
Print2DArray(userArray);
SredArifm(userArray);
Console.WriteLine();