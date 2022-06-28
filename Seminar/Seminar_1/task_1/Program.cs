// Задача №1: Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.

int first_number = Convert.ToInt32(Console.ReadLine());
int second_number = Convert.ToInt32(Console.ReadLine());
if (second_number == first_number * first_number)
{
    Console.WriteLine("Яыляется");
}
else
{
    Console.WriteLine("Не является");
}
