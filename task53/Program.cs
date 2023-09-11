/* задайте двумерный массив. напишите прогу кот поменяет местами
первую и последнюю строку массива
*/

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

int [,] ResultArray (int [,] array)
{
int rows = array.GetLength(0);
int cols = array.GetLength(0);
int temp = 0;
for (int i = 0; i < cols, i++)
{
    temp = array[0, i];
    array [0, i] = array [rows-1, i];
    array [rows-1, i] = temp;
}
return array; 
}

int[,] userArray = Get2DArray(4, 4, 0, 10);
Print2DArray(userArray);
Console.WriteLine();
int[,] userArray2 = ResultArray(userArray);
Print2DArray(userArray2);