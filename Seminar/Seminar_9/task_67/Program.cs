// Напишите программу, которая принимает на вход число и выдает сумму его цифр

Console.WriteLine("Ввведите число");
int number = CheckingInt();

int CheckingInt()
{
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Вы ввели не натуральное число. Повторите ввод!");
    }
    return number;
}

SumOfDigitsInNumber(number);

void SumOfDigitsInNumber(int number, int sum=0)
{
    if (number > 0)
    {
        sum = sum + number % 10;
        SumOfDigitsInNumber(number / 10, sum);
    }
    else
    {
        Console.WriteLine(sum);
        return;
    }
}
