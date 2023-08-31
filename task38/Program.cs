/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());


double[] GetArray (int arrayL)
{
double[] array = new double[arrayL];
for (int i = 0; i < arrayL; i++)
{
array[i] = new Random().NextDouble();
Console.Write($"{array[i]:F2} {" "}");
}
return array;
}





double Raz(double[] array)
{
double min = array[0];
double max = array[0];
int i = 1;
while (i < array.Length)
{
if (max<array[i])
max = array[i];
if (min>array[i])
min = array[i];
i = i + 1;
}
return max-min;
}


double[] userArray = GetArray(length);

Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементов массива: {Raz(userArray):F2}");