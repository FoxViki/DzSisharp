/*
Напишите программу, которая на вход принимает оно число,
а на выходе выдает его квадрат (число умноженное на себя)

4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;
Console.WriteLine(result);
