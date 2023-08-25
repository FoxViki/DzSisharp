/*напишите рограмму, которая принимает на вход число ф
и выдает произведение чисел от 1 до ф.*/

Console.WriteLine("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int ProductOfNumber(int number)
{
    int product = 1;
    while (number != 0)
    {
        product *= number;
        number--;
    }
    return product;
}
Console.WriteLine(ProductOfNumber(userNumber));



ИЛИ ЕЩЕ МОЖНО


Console.WriteLine("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int MuitOfNumber(int number)
{
    int mult = 1;
    for (int i = 1; i <= userNumber; i++)
    {
        muil *= i;
    }
    return mult;
}
Console.WriteLine($" Произведение цифр в числе {userNumber} равно {mult}");
