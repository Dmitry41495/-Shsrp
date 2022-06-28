// Задача №2: Напишиет программу, которая на вход принимает два числа и выдает, какое число больше, а каое меньше.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (a > b)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else
    {
         Console.WriteLine("Второе число больше второго");
    }
}

