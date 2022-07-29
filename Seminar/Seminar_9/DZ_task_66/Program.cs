// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.WriteLine("Ввведите натуральное число N");
int n = CheckingNaturalNumber();
Console.WriteLine("Ввведите натуральное число M ");
int m = CheckingNaturalNumber();

Console.WriteLine(AckermanFunction(m, n));

int CheckingNaturalNumber()
{
    bool check = true;
    int number = 0;
    while (check)
    {
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Вы ввели не натуральное число. Повторите ввод!");
        }
        if (number < 0)
        {
            Console.WriteLine("Вы ввели не натуральное число. Повторите ввод!");
        }
        else
            check = false;
    }
    return number;
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}
