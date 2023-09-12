﻿/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.*/


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
};

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

int[,] SortirStroki(int[,] array, int row)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[row, j] < array[row, j + 1])
            {
                temp = array[row, j];
                array[row, j] = array[row, j + 1];
                array[row, j + 1] = temp;
            }
        }
    }
    return array;
}


int[,] SortirVsegoArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row ++)
    {
        SortirStroki(array, row);
    }
    return array;
}

int[,] userArray = Get2DArray(3 ,5, 0, 10);
Print2DArray(userArray);
Print2DArray(SortirVsegoArray(userArray));