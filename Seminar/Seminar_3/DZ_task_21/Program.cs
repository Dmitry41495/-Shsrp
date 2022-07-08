// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double x1 = 0;
double x2 = 0;
double y1 = 0;
double y2 = 0;
double z1 = 0;
double z2 = 0;


System.Console.WriteLine("Введите координату х1: ");
while (!double.TryParse(Console.ReadLine(), out x1))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

System.Console.WriteLine("Введите координату х2: ");
while (!double.TryParse(Console.ReadLine(), out x2))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

System.Console.WriteLine("Введите координату y1: ");
while (!double.TryParse(Console.ReadLine(), out y1))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

System.Console.WriteLine("Введите координату y2: ");
while (!double.TryParse(Console.ReadLine(), out y2))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

System.Console.WriteLine("Введите координату z1: ");
while (!double.TryParse(Console.ReadLine(), out z1))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

System.Console.WriteLine("Введите координату z2: ");
while (!double.TryParse(Console.ReadLine(), out z2))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

// Формула нахождения расстояния между точкоми в пространстве AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

System.Console.Write("Расстояние между точками в пространстве, при данных координатах = ");
System.Console.WriteLine(
                        Math.Sqrt(
                                (x2 - x1) * (x2 - x1) +
                                (y2 - y1) * (y2 - y1) +
                                (z2 - z1) * (z2 - z1)
                                )
                        );