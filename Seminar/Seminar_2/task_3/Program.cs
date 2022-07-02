int number_1;
int number_2;
Console.WriteLine("Введите первое число: ");
while ( ! int.TryParse(Console.ReadLine(), out number_1))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}
Console.WriteLine("Введите второе число: ");


while ( ! int.TryParse(Console.ReadLine(), out number_2))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

if (number_1 % number_2 == 0)
{
    Console.WriteLine($"{number_1}, {number_2} -> кратно");
}
else
{
     Console.WriteLine($"{number_1}, {number_2} -> не кратно, остаток {number_1 % number_2}");
}
