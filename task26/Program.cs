/*напишите программу, которая на вход принимает число,
а на выходе считает количество цифр в числе.
*/

Console.WriteLine("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Quantity(int number)
{
    int count = 0;
    while (number >0)
    {
        count++;
        number = number/10;
    }
    return count;
};
