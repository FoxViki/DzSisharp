/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


Console.Clear();


int[] MyArray(int[] array)
{
    int[] arrayL = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число массива: ");
        arrayL[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrayL;
};

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


int QuantityNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count +1;
        }
    }
    return count;
};

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [length];

int[] userArray = MyArray(array);
PrintArray(userArray);

Console.WriteLine();
Console.WriteLine($"Количество положительных чисел = {QuantityNumber(userArray)}");
