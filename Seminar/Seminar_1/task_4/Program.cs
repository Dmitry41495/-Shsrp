// Задача №4: Напишет программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите теретье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
{
    max = b;
    if (b < c) max = c;
}
else if (a < c) max = c;
Console.Write("Максимальное число ");
Console.WriteLine(max);
