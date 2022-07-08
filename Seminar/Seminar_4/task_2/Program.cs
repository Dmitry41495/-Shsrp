//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int numberOfDigits(int number)
{
    int count = 0;
    for(; number != 0; number /= 10)
    {
        count++;
    }
    return count;
}


System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

System.Console.WriteLine(numberOfDigits(num));

System.Console.WriteLine((int) Math.Log10(num) + 1);