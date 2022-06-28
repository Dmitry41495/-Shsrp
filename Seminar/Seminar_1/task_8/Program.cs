// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (N > 0)
{
    while (i <= N)
    {
        Console.Write(i);
        Console.Write(" ");
        i+=2;
    }
}
else Console.WriteLine("Неверный ввод");

