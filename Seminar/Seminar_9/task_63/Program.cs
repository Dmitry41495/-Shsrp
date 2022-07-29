// Задайте число N и напишите программу, которая выводит все натуральные числа от 1 до N

Console.WriteLine("Ввведите натуральное число N");
int n = CheckingNaturalNumber();

SeriesOfNumbers(0, n);

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

void SeriesOfNumbers(int temp, int lastNumber)
{
    if (temp > lastNumber)
    {
        return;
    }
    else
    {
        Console.Write($"{temp}, ");
        SeriesOfNumbers(temp + 1, lastNumber);
    }
}
