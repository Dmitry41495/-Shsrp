// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N/
int factorialOfANumber(int number)
{
    int factorial = 1;
    if (number > 0)
    {
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    }
    else factorial = 0;
    return factorial;
}

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

System.Console.WriteLine(factorialOfANumber(num));


