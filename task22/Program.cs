/* 22. Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
*/

Console.WriteLine("Введи число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i <= numberN; i = i + 1)
{
    int result = i*i;
    Console.Write(result);
}