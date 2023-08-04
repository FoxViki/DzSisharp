/*напишите прагму, кот на вход принимает число и выдает,
является ли число четным
*/
Console.WriteLine("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n%2 == 0)
{
    Console.WriteLine("Число{n} - четное");
}
else(n%2 == 1)
{
    Console.WriteLine("Число{n} - нечетное");
}