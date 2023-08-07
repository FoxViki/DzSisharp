/*11. Напишите программу, которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа.

11:30
456 -> 46
782 -> 72
918 -> 98

11:31
Анастасия Булючева
*/
int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int numberOne = number / 100;
Console.WriteLine(numberOne);

int numberThree = number % 10;
Console.WriteLine(numberThree);

int result = numberOne*10 + numberThree;
Console.WriteLine(result);


/*Валерия Шарандина
Администратор
12. Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.

11:47
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 % number2 == 0)
{
    Console.WriteLine($"Число {number1} кратно {number2}");
}
else
{
    int number3= number1 % number2;
    Console.WriteLine($"Остаток равен {number3}");
}