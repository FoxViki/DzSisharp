/* написать прагму ,кот на вход принимает число N, а выдает все целые числа
в промежутке от -N до N
*/
Console.WriteLine("Введи число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
for(int i = -numberN; i <= numberN; i ++)
{
    Console.Write(i +" ");
}