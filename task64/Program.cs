/*/*Задача 64: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine("Введите начало отсчета: ");
int start = Convert.ToIn32(Console.ReadLine());

void NuturalNum(int finish = 1, int start)
{
if (start >= finish)
{
Console.Write(start +", ");
NuturalNum(finish, start - 1);
}
}
NuturalNum(int start);
