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




/*

Василий AsmuZ Просыпаемся сони!
Никита Шаров Привет
Анастасия Павлова Всем привет! Волшебного настроения!
Никита Шаров Привет
Анастасия Павлова Валерия, мы с Вами в одной лодке. Аллергия+простуда это очень весело.
Анастасия Павлова Я в большой VS не разобралась вообще(((
Никита Шаров int[,] SortDecreaseRowsInArray(int[,] arrayForSort)
{
bool sorted;

do
{
sorted = false;
for (int i = 0; i < arrayForSort.GetLength(0); i++)
{
for (int j = 1; j < arrayForSort.GetLength(1); j++)
{
if (arrayForSort[i, j - 1] < arrayForSort[i, j])
{
int temp = arrayForSort[i, j - 1];
arrayForSort[i, j - 1] = arrayForSort[i, j];
arrayForSort[i, j] = temp;
sorted = true;
}
}
}
} while (sorted);

return arrayForSort;
}
Никита Шаров int[] SumRowsIn2DArray(int[,] array)
{
int[] sumRows = new int[array.GetLength(0)];

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
sumRows[i] += array[i, j];
}
}

return sumRows;
}
Никита Шаров void PrintSmallestElement(int[] array)
{
int smallestSum = array[0];
int rowFrom2DArray = 0; // Номер элементна будет соответствовать строке в двумерном массиве.

for (int i = 1; i < array.Length; i++)
{
if (smallestSum > array[i])
{
smallestSum = array[i];
rowFrom2DArray = i;
}
}

Console.WriteLine($"Наименьшая сумма элементов будет в {rowFrom2DArray} строке и она равна {smallestSum}");
}
*/
