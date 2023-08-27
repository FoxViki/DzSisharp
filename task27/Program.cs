/*Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumNumber(int number)
{
    while (number > 0)
    {
        sum = sum + number%10;
        number = number/10;
    }
    return sum;
}
Console.WriteLine(SumNumber(userNumber));


