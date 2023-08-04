/* Напишите программу, которая принимает на вход два числа
и проверяет, является ли одно число квадратом другого.

12:13
5, 25 -> да
-4, 16 -> да
25, 5 -> да

*/


int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int kvadrat = number1 * number2;
if(number1 == number2*number2 || number2 == number1 * number1)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}