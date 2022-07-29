// Задайте числа M и N. Напишите программу которая выводти все числа от N до M.

Console.WriteLine("Ввведите натуральное число N");
int n = CheckingNaturalNumber();
Console.WriteLine("Ввведите натуральное число M до которого нужно выводить последовательность");
int m = CheckingMaxNaturalNumber(n);

SeriesOfNumbers(n, m);

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

void SeriesOfNumbers(int firstNumber, int lastNumber)
{
    if (firstNumber > lastNumber)
    {
        return;
    }
    else if(firstNumber == lastNumber)
    {
        Console.Write($"{firstNumber}");
        SeriesOfNumbers(firstNumber + 1, lastNumber);
    }
    else
    {
        Console.Write($"{firstNumber}, ");
        SeriesOfNumbers(firstNumber + 1, lastNumber);
    }
}
