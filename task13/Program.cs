/*Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}
if (number >= 100)
{
while (number >999)
{
    number = number / 10;
}
number = number % 10;
Console.WriteLine(number);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
