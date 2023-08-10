/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int number = Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else if (number >= 1 || number <= 5)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}