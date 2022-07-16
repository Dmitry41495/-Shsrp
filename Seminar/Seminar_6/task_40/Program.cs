// Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник такой длины

System.Console.WriteLine("Введите длину первой стороны");

int firstSide = CheckingDataEntry();

System.Console.WriteLine("Введите длину второй стороны");

int secondSide = CheckingDataEntry();

System.Console.WriteLine("Введите длину третьей стороны");

int thirdSide = CheckingDataEntry();

CheckingForATriangle(firstSide, secondSide, thirdSide);

void CheckingForATriangle(int first, int second, int third)
{
    if(first+second > third && second+third >first && first+third >second)
    {
        System.Console.WriteLine("Является треугольником");
    }
    else
    {
        System.Console.WriteLine("Не является теругольником");
    }
}


int CheckingDataEntry()
{
    int outputData = 0;
    bool trigger = false;
    while(trigger == false)
    {
        while (!int.TryParse(Console.ReadLine(), out outputData))
        {
            System.Console.WriteLine("Неверный ввод, введите число заново!");
        }
        if (outputData>0) 
        {
            trigger = true;
        }
        else
        {
            System.Console.WriteLine("Неверный ввод, введите длину заново!!");
        }
    }
    return outputData;
}

