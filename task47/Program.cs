﻿/* Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


Console.WriteLine("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

double[,] Get2DArray(int row, int col)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
    return array;
}

void PrintDouble2DArray(double[,] array)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2}  \t");
        }
        System.Console.WriteLine();
    }
};

double[,] array = Get2DArray(row, col);
PrintDouble2DArray(array);




или 
Console.WriteLine("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] Get2DArray(int row, int col, int min, int max)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().NextDouble()*(max-min)+(min);
        }
    }
    return array;
}

void PrintDouble2DArray(double[,] array)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2}  \t");
        }
        System.Console.WriteLine();
    }
};

double[,] array = Get2DArray(row, col, min, max);
PrintDouble2DArray(array);