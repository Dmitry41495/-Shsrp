// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Ввведите натуральное число N");
int n = CheckingNaturalNumber();
Console.WriteLine("Ввведите натуральное число M до которого нужно искать сумму");
int m = CheckingMaxNaturalNumber(n);

SumNaturalElements(n, m);

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

int CheckingMaxNaturalNumber(int minNumber)
{
    bool check = true;
    int maxNumber = 0;
    while (check)
    {
        while (!int.TryParse(Console.ReadLine(), out maxNumber))
        {
            Console.WriteLine("Вы ввели не натуральное число. Повторите ввод!");
        }
        if (maxNumber < minNumber)
        {
            Console.WriteLine("Введенное число M должно быть больше N. Повторите ввод.");
        }
        else
        {
            check = false;
        }
    }
    return maxNumber;
}

void SumNaturalElements(int firstNumber, int lastNumber, int sum = 0)
{
    if (firstNumber > lastNumber)
    {
        Console.Write($"{sum}");
        return;
    }
    else
    {
        sum = sum + firstNumber;
        SumNaturalElements(firstNumber + 1, lastNumber, sum);
    }
}
