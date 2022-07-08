//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.WriteLine("Введите целое число");

int number;
int degree = 0;

while (!int.TryParse(Console.ReadLine(), out number))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!");
}

System.Console.WriteLine("Введите степень в которую нужно возвести число");

for (bool i = false; i == false;)
{
    while (!int.TryParse(Console.ReadLine(), out degree))
    {
        System.Console.WriteLine("Неверный ввод, введите степень заново!");
    }
    if (degree > 0)
    {
        i = true;
    }
    else
    {
        System.Console.WriteLine("Неверный ввод, введите степень заново!");
    }
}

int RaiseToADegree(int number, int degree)
{
    int numberToThePower = 1;
    for (int i = 1; i <= degree; i++)
    {
        numberToThePower = numberToThePower * number;
    }
    return numberToThePower;
}

System.Console.WriteLine($"Число {number} в степени {degree} = {RaiseToADegree(number, degree)}");
