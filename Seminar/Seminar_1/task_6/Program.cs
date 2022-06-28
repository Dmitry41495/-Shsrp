// Напишите программу, которая на вход принимает число и выдает, является ли число четным.
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) 
{
    Console.WriteLine("Число введенное вами четное");
}
else Console.WriteLine("Число введеное ваим нечетное");