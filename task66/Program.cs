/*Задача 66: Задайте значения M и N. Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите начало отсчета: ");
int start = Convert.ToIn32(Console.ReadLine());
Console.WriteLine("Введите конец отсчета: ");
int finish = Convert.ToIn32(Console.ReadLine());

int SumNum(int start, int finish,)
{
if (start == 0 && finish == 0) return 0;
else if(start == finish) return finish;
else if(start <= finish) return start  + SumNum(finish, start + 1);
else if (start >= finish) return start  + SumNum(finish, start - 1);
}
int result = SumNum(int start, int finish);

