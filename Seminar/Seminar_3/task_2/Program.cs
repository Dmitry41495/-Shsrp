void printRangeXY(float planeNumber)
{
    if (planeNumber == 1) 
    {
        System.Console.WriteLine("Х положительный");
        System.Console.WriteLine("Y положительный");
    }
        
    else if (planeNumber == 2)
    {
        System.Console.WriteLine("Х отрицательный");
        System.Console.WriteLine("Y положительный");
    }
        
    else if (planeNumber == 3)
    {
        System.Console.WriteLine("Х отрицательный");
        System.Console.WriteLine("Y отрицательный");
    }
       
    else if (planeNumber == 4)
    {
        System.Console.WriteLine("Х положительный");
        System.Console.WriteLine("Y отрицательный");
    }
        
    else 
    System.Console.WriteLine("Некорректный ввод данных");
}

int planeNumber;

while ( ! int.TryParse(Console.ReadLine(), out planeNumber))
{
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
}

printRangeXY (planeNumber);
