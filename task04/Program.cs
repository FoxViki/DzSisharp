/* Напишите прагму, кот принимает на вход 3 числа
и выдает максимальное из этих чисел
*/
Console.WriteLine("Введи первое числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max =c;

Console.WriteLine(max);