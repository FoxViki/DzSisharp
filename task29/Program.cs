/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


Console.WriteLine("Введи число: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int [] GetRandomArray()
{
    int [] array = new int [lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

int[] userArray = GetRandomArray();
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{arrayToPrint[i]}");
    }
    Console.WriteLine("]");
};
PrintArray(userArray);