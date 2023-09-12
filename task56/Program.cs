﻿/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. 
*/


int[,] Get2DArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
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
};

int Summa(int[,] array, int row)
{
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[row, j];
        }
    return sum;
};

int MinSumStr(int[,] array)
{
    int row = 0;
    int minSum = Summa(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (Summa(array, i) < minSum)
        row = i;
        minSum = Summa(array, i);
        Console.Write($"Сумма {row} строки: " + Summa(array, i));
        Console.WriteLine();
    }
    return row;
}

int[,] userArray = Get2DArray(3, 4, 0, 10);
Print2DArray(userArray);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {MinSumStr(userArray)}");

