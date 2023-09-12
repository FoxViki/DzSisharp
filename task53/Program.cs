/* 53 Задайте двумерный массив. Напишите программу, которая поменяет
местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2 */

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
for (int i = 0; i < arrayToPrint.GetLength(0); i++)
{
for (int j = 0; j < arrayToPrint.GetLength(1); j++)
{
System.Console.Write(arrayToPrint[i, j] + "\t");
}
System.Console.WriteLine();
}
}

int[,] ResultArray(int[,] array)
{
int rows = array.GetLength(0);
int cols = array.GetLength(1);
int temp = 0;

for (int i = 0; i < cols; i++)
{
temp = array[0, i];
array[0, i] = array[rows - 1, i];
array[rows - 1, i] = temp;
}

return array;
}

int[,] arr = Get2DArray(4, 4, 0, 10);
Print2DArray(arr);
System.Console.WriteLine();
int[,] arr2 = ResultArray(arr);
Print2DArray(arr2);



