/* напишите прагму, кот принимает трехзначное число,
а на выходе показывает последнюю цыфру этого же числа
*/

Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99 && number<1000)
{
    Console.WriteLine(number%10);
}
else
{
   Console.Write("Число не трехзначное"); 
}