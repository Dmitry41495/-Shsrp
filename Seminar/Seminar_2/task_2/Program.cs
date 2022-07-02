int number = new Random().Next(10, 100);
System.Console.WriteLine("Дано число: ");
System.Console.WriteLine(number);
if (number / 10 > number % 10)
{
    System.Console.Write("самая большая цифра числа: ");
    System.Console.WriteLine(number / 10);
}
else
{
    System.Console.Write("самая большая цифра числа: ");
    System.Console.WriteLine(number % 10);
}