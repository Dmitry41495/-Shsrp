// Задайте двумерный массив размером m x n заполненый случайными числами

Console.WriteLine("Введите число сток массива: ");
int m = checkingDataEntry();
Console.WriteLine("Введите число сток массива: ");
int n = checkingDataEntry();
Console.WriteLine("Введите минимальное значение чисел в массиве: ");
int minNumberArray = checkingDataEntry();
Console.WriteLine("Введите максимальное значение чисел в массиве: ");
int maxNumberArray = CheckingForMax(minNumberArray);

PrintArray(
    FillArray(m, n, minNumberArray, maxNumberArray)
);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] FillArray(int row, int column, int min, int max)
{

    int[,] array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

int checkingDataEntry()
{
    int outputData;
    while (!int.TryParse(Console.ReadLine(), out outputData))
    {
        System.Console.WriteLine("Неверный ввод, введите число заново!");
    }
    return outputData;
}

int CheckingForMax(int min)
{
    bool check = false;
    int max = 0;
    while(check == false)
    {
        max = checkingDataEntry();
        if(max>min)check = true;
        else System.Console.WriteLine(
            "Число введенное вами как максимальное меньше или равно минимальному. Повторите ввод!");

    }
    return max;
}