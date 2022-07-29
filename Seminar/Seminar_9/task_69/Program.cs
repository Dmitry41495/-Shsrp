// Напишите программу которая принимает на вход числа a и b
// и возводит число a в натуральную степень b

Console.WriteLine("Ввведите число а");
int a = CheckingInt();
Console.WriteLine("Ввведите число b");
int b = CheckingInt();

PrintExponentiation(a, b);

int CheckingInt()
{
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Вы ввели не натуральное число. Повторите ввод!");
    }
    return number;
}

void PrintExponentiation(int a, int b, double numberInPower = 1, bool sing = true)
{
    if (b == 0)
    {
        if (sing)
        {
            System.Console.WriteLine($"Число а в степени b = {numberInPower}");
            return;
        }
        else
        {
            System.Console.WriteLine($"Число а в степени b = {(double)1 / numberInPower}");
            return;
        }
    }
    else if (b > 0)
    {
        sing = true;
        numberInPower *= (double)a;
        PrintExponentiation(a, b - 1, numberInPower, sing);
    }
    else
    {
        sing = false;
        numberInPower *= (double)a;
        PrintExponentiation(a, b + 1, numberInPower, sing);
    }
}


