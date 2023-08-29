/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/


System.Console.WriteLine("Введи число: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
double minim = Convert.ToInt32(Console.ReadLine());
double maxim = Convert.ToInt32(Console.ReadLine());

void ControlMinMax(double mininal, double maximal)
{
    if (minimal < 0 && maximal < 0)
    {
        Console.WriteLine("Введите корректное число");
    }
}


double[] GetRandomArray(int arrayLength1, double start, double end)
{
    double[] array = new double[arrayLength1];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(double [] arrayToPrint)
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
}

double MinMaxNumber(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 0;
    
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i]< min)
        {
            min = array[i];
        }
    }
    return min;
    return max;
    Console.WriteLine($" {double min} = {min}");
    Console.WriteLine($" {double max} = {max}");
}

double Raznost(userArray)
{
    double razn = max - min;
    return razn;
}

ControlMinMax(minim, maxim);
double[] userArray = GetRandomArray(arrayL, minim, maxim);
PrintArray(userArray);
MinMaxNumber(userArray);
double raz = Raznost(min, max);
Console.WriteLine();
Console.WriteLine(sumNPoz);