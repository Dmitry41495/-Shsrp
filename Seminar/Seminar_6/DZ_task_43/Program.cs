// // Напишите программу, которая найдёт точку пересечения двух прямых,
// //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

System.Console.WriteLine("Введите параметр k1: ");
int k1 = CheckingDataEntry();
System.Console.WriteLine("Введите параметр b1: ");
int b1 = CheckingDataEntry();
System.Console.WriteLine("Введите параметр k2: ");
int k2 = CheckingDataEntry();
System.Console.WriteLine("Введите параметр b2: ");
int b2 = CheckingDataEntry();

if (k1 != k2)
{
    System.Console.WriteLine("Координаты точки пересечения прямых с заданными параметрами равны:");
    System.Console.WriteLine($"x = {XCoordinateOfThePoint(k1, b1, k2, b2)}");
    System.Console.WriteLine($"y = {YCoordinateOfThePoint(k1, b1, k2, b2)}");
}
else if (b1 == b2)
{
    System.Console.WriteLine("Заданные прямые совпадают (бесконечное множество точек пересечения)ю");
}
else
{
    System.Console.WriteLine("Заданные прямые паралельны и не пересекаются");
}



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

double XCoordinateOfThePoint(int k1, int b1, int k2, int b2)
{
    double x = (double)(b2 - b1) / (k1 - k2);
    return x;
}

double YCoordinateOfThePoint(int k1, int b1, int k2, int b2)
{
    double y = (double)k1 * (b2 - b1) / (k1 - k2) + b1;
    return y;
}



