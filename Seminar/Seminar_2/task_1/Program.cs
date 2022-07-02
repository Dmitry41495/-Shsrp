// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Веедите 3-х значное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 1000 ||  a > -1000 && a < -99)
{
    Console.Write("Последняя цифра числа ");
    Console.WriteLine(a % 10);
}
else Console.WriteLine("Неверный ввод");
