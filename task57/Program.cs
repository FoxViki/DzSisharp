/*Составить частотный словарь элементов двумерного массива.
Словарь содержит инфу о том, сколько раз встречается элемент входных данных*/

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

int[] ExpendMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0)*matrix.GetLength(1);
    int[] array = new int[n];
    n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n] = matrix[i, j];
            n++;
        }
    }
    return array;
}

int CollectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = 0; j < array.Length; ji++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        if (i != minPosition)
        {
            int tmp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = tmp;
        }
    }
    return array;
}

void PrintArray(int [] arrayToPrint)
{
    Console.Write("[");
    for (int i=0; i<arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i]);
       if (i<arrayToPrint.Length - 1)
       {
        Console.Write (", ");
       }
    }
    Console.Write("]");
};

void Count(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        int number = array[i];
        for (int j = 0; j < array.Length; j++)
        {
            if (number == array[j]) count ++
        }
        Console.WriteLine($"Число {number} встречается {count} раз")
    }
}



int[,] user2DArray = Get2DArray(5, 5, 0, 10);
Print2DArray(user2DArray);
Console.WriteLine();
int[] userAray = ExpendMatrix(user2DArray);
PrintArray(userAray);
int[] sortArray = CollectionSort(userAray);
PrintArray(sortArray);
Count(sortArray);



/*
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



int[] Convert2DArrayToArray (int[,] array2DForConvert)
{
    int index = 0;
    int rows = array2DForConvert.GetLength(0);
    int cols = array2DForConvert.GetLength(1);
    int[] array = new int[rows*cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array [index] = array2DForConvert[i, j];
            index++;
        }
    } return array;
}
void PrintFrequencyVocabulary(int[] arrayForCountNumber)
{
    for (int number = 0; number < 10; number++)
    {
        int countNumber = 0;
        for (int i = 0; i < arrayForCountNumber.Length; i++)
        {
            if (number==arrayForCountNumber[i]) countNumber++;
        }
        if (countNumber != 0) Console.WriteLine($"Число {number} встречается {countNumber} раз")
    }
}

int[,] user2DArray = Get2DArray(5, 5, 0, 10);
int[] userArray = Convert2DArrayToArray(user2DArray);

Print2DArray(user2DArray);
Console.WriteLine();
PrintFrequencyVocabulary(userArray);*/