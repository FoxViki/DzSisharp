/*18. Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).*/

System.Console.WriteLine("Введите номер четверти: ");
int userN = Convert.ToInt32(Console.ReadLine());

if(userN==1)
{
    System.Console.WriteLine("Диапазон координат точек {X>0} : {Y>0} ");
}
else if(userN==2)
{
    System.Console.WriteLine("Диапазон координат точек {X<0} : {Y>0} ");
}
else if(userN==3)
{
    System.Console.WriteLine("Диапазон координат точек {X<0} : {Y<0} ");
}
else if (userN==4)
{
    System.Console.WriteLine("Диапазон координат точек {X>0} : {Y<0} ");
}
else
{
    System.Console.WriteLine("Нет такой четверти");
}


ИЛИ МОЖНО ТАК


Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number ==1)
{
    System.Console.WriteLine("X>0, Y>0");
}
else if(number ==2)
{
    System.Console.WriteLine("X<0, Y>0");
}
else if(number ==3)
{
    System.Console.WriteLine("X<0, Y<0");
}
else if(number ==4)
{
    System.Console.WriteLine("X>0, Y<0");
}
else
{
    System.Console.WriteLine("Нет такой четверти");
}