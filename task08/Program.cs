/* Напишите программу, которая на входе берет число N,
в на выходе выдает все четные числа от 1 до N
*/
Console.WriteLine("Введи число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= numberN; i ++)
{
    Console.Write(i +" ");
}