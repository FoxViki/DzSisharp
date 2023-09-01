/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


using System.Runtime.CompilerServices;

Console.WriteLine("Введите числа: ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double SearchX(double b1, double k1, double b2, double k2)
{
    /*y == k1 * x + b1;
    y == k2 * x + b2;
    k1 * x +b1 == k2 * x +b2;
    k1*x - k2*x == b2 - b1;
    (k1-k2)*x==b2-b1;*/
    double x = (b2-b1)/(k1-k2);
    return x;
};

double xP = SearchX(b1, k1, b2, k2);

double SearchY(double x, double b1, double k1)
{
    double y = (k1 * x) + b1;
    return y;
};

double yP = SearchY(xP, b1, k1);

Console.WriteLine();
Console.Write(xP);
Console.WriteLine();
Console.Write(yP);
Console.WriteLine();
Console.WriteLine($"(Точка пересечения имеет координаты [{xP}, {yP}])");
