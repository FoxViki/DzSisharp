/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

11:09
78 -> 8
12-> 2
85 -> 8

*/

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int numberOne = number / 100;
Console.WriteLine(numberOne);

int numberThree = number % 10;
Console.WriteLine(numberThree);

int result = numberOne*10 + numberThree;
Console.WriteLine(result);
