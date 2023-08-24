/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = (number/10000);
int b = (number/1000) - a*10;
int c = (number/100) - (a*100+b*10);
int d = (number/10) - (a*1000+b*100+c*10);
int e = number - (a*10000+b*1000+c*100+d*10);

int number1 = e*10000+d*1000+c*100+b*10+a;
Console.WriteLine(number1);
if (number == number1)
{
    Console.WriteLine($"Число {number1} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number1} не является палиндромом");
}
