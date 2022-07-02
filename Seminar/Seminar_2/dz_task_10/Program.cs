// Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

int secondDigitOfTheNumber(int number)
{
    int secondDigit = number % 100 /10;
    return Math.Abs(secondDigit);
}

int number = 0;
int i = 0;

System.Console.WriteLine("Введите трехзначное число");
while(i == 0)
{
    while (! int.TryParse(Console.ReadLine(), out number))
    {
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
    }    

    if (number > 99 && number < 1000) i++;
    else System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

System.Console.WriteLine($"Вторая цифра трехначного числа: {secondDigitOfTheNumber(number)}");
