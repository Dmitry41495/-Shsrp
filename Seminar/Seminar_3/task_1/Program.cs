// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X и Y не равны 0 и выдет номер четверти плоскости, в которой находится эта точка.
int getNumberOfPlain(float x, float y)
{
    if (x > 0 && y > 0) 
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

    return -1;
}

void printPlainsNumber(float x, float y)
{
    if (x > 0 && y > 0) 
        System.Console.WriteLine("Плоскость 1");
    else if (x < 0 && y > 0)
        System.Console.WriteLine("Плоскость 2");
    else if (x < 0 && y < 0)
        System.Console.WriteLine("Плоскость 3");
    else if (x > 0 && y < 0)
        System.Console.WriteLine("Плоскость 4");
    else 
    System.Console.WriteLine("Некорректный ввод данных");
}
//printPlainsNumber (2, -3);


int plainNumbers = getNumberOfPlain(1, 5);
if (plainNumbers != -1)
    System.Console.WriteLine(plainNumbers);
else
    System.Console.WriteLine("Некорректный ввод данных");