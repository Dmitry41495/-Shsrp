// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле:
// Amn = m+n. Вывидите полученный результат на экран.

Console.WriteLine("Введите число сток массива: ");
int m = checkingDataEntry();
Console.WriteLine("Введите число сток массива: ");
int n = checkingDataEntry();

PrintArray(
    FillArraySumIndex(m, n)
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

int[,] FillArraySumIndex(int row, int column)
{

    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = i + j;
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

