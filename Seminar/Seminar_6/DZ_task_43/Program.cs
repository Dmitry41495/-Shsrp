// Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

System.Console.WriteLine("Введите параметр k1: ");
int k1 = CheckingDataEntry();
System.Console.WriteLine("Введите параметр b1: ");
int b1 = CheckingDataEntry();
System.Console.WriteLine("Введите параметр k2: ");
int k2 = CheckingDataEntry();
System.Console.WriteLine("Введите параметр b2: ");
int b2 = CheckingDataEntry();

System.Console.WriteLine("Координаты точки пересечения прямых с заданными параметрами равны:");
System.Console.WriteLine($"x = {XCoordinateOfThePoint(k1, b1, k2, b2)}");
System.Console.WriteLine($"y = {YCoordinateOfThePoint(k1, b1, k2, b2)}");

int CheckingDataEntry()
{
    int outputData = 0;

    {
        while (!int.TryParse(Console.ReadLine(), out outputData))
        {
            System.Console.WriteLine("Неверный ввод, введите число заново!");
        }
    }
    return outputData;
}

int XCoordinateOfThePoint(int k1, int b1, int k2, int b2)
{
    int x = (b2 - b1) / (k1 - k2);
    return x;
}

int YCoordinateOfThePoint(int k1, int b1, int k2, int b2)
{
    int y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return y;
}
