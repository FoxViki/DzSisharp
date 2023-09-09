﻿/*Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();
Console.Write("Укажите число строк: ");
int rowslen = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число столбцов: ");
int colslen = Convert.ToInt32(Console.ReadLine());

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

int[,] userArray = Get2DArray(rowslen,colslen, 0, 10);
Print2DArray(userArray);

Console.Write("Укажите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine());

void GetArrayElement(int[,] array, int row, int col, int rowslen, int colslen)
{
    if (row < rowslen && col < colslen) 
    Console.WriteLine($"Значение элемента в ячейке равно {array[row, col]}");
    else Console.WriteLine("Такого числа нет");
}

GetArrayElement(userArray, row, col, rowslen, colslen);
