// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("Введите целое число");

int number;

while (!int.TryParse(Console.ReadLine(), out number))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!");
}

int SumOfDigits(int number)
{
    string numberToString = Convert.ToString(number);
    int length = numberToString.Length;
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;

}

System.Console.WriteLine(SumOfDigits(number));

