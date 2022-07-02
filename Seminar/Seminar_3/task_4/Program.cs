void PrintSquaresOfNumber(int n)
{
    int count = 1;
    int SquareOfNumber = 1;
    if (n > 0)
    {
        while (count <= n)
        {
       System.Console.WriteLine(count*count);
       count++;
        }
    }
    else if (n == 0)
    {
        System.Console.WriteLine(1, 0);
    }
    else
    {
         while (count >= n)
        {
       System.Console.WriteLine(count*count);
       count--;
        }
    }
}

int number;
Console.WriteLine("Введите число: ");
while ( ! int.TryParse(Console.ReadLine(), out number))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

PrintSquaresOfNumber(number);
