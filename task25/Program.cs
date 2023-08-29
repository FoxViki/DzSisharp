/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B. 

ПРОВЕРИТЬ В НА ОТРИЦАТЕЛЬНОСТЬ

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введи числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Pow(number1, number2));
