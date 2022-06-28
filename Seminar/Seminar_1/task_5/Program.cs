// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все уелые числа а промежутке от -N до N
Console.WriteLine("Введите целое число");
 int N = Convert.ToInt32(Console.ReadLine());
int i = -N;

 if (N > 0)
 {
        while (i <= N)
    {
        Console.Write(i);
        Console.Write(" ");
        i++;
    }
 }
else
{
    while (N <= i)
    {
        Console.Write(i);
        Console.Write(" ");
        i--;
    }
}