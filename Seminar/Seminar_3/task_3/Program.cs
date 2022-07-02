void PrintLengthBetweenPoints (double x1, double y1, double x2, double y2)
{
    System.Console.WriteLine(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)));
}

System.Console.WriteLine("Введите координату Х первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату Y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату Х второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату Y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());

PrintLengthBetweenPoints(x1, y1, x2, y2);