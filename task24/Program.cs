/* напишите программу, которая на вход принимает число и выдает сумму цифр от 1 до а.
*/

/*

Console.WriteLine("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= userNumber; i++)
{
    sum += i;
}
Console.WriteLine(sum);



ИЛИ МОЖНО ТАК */

Console.WriteLine("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SumOfNumber(int number);
{
    int sum = 0;
    for (int i = 1; i <= userNumber; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine($"сумма чисел в числе {userNumber} равна {SumOfNumber(userNumber)}");
