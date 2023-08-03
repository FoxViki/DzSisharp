/* Написать программу, которая на вод принимает 2 числа и проверяет,
является ли перве число квадратом второго
*/

Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго числа");
}