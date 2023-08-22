Console.WriteLine("Введите число: ") 
int number1 = Convert.ToInt32(Console.ReadLine());
int a = Math.Round(number1/10000);
int b = Math.Round(number1/1000) - a*10;
int c = Math.Round(number1/100) - (a*100+b*10);
int d = Math.Round(number1/10) - (a*1000+b*100+c*10);
int e = number1 - (a*10000+b*1000+c*100+d*10);
int temp = 0;
int temp1 = 0;
temp = a;
int a = e;
int e = temp;
temp1 = b;
int b = d;
int d = temp1;
int number2 = a*10000+b*1000+c*100+d*10+e;
Console.WriteLine(number2);
if (number1 == number2)
{
    Console.WriteLine($"Число {number1} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number1} не является палиндромом");
}