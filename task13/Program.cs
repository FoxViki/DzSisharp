/*Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int number = Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 || number < 1000)
{
    int numberOne = number / 100;
    Console.WriteLine(numberOne);
}
else
{
    {Console.WriteLine("третьей цифры нет");}
}