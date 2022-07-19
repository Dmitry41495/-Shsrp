// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

System.Console.WriteLine("Введите количество строк двумерного массива:");
int rowsNumber = CheckingForIntPositive();
System.Console.WriteLine("Введите количество столбцов двумерного массива:");
int columnNumber = CheckingForIntPositive();
System.Console.WriteLine("Введите максимальное значение элемента массива:");
double maxEl = CheckingForDouble();

double[,] matrix = GetMarixDouble(rowsNumber, columnNumber, maxEl);

PrintArray(matrix);

double CheckingForDouble()
{
    double outputData = 0;
    while (!double.TryParse(Console.ReadLine(), out outputData))
    {
        System.Console.WriteLine("Невернвй ввод, Введите заново");
    }
    return outputData;
}

int CheckingForIntPositive()
{
    int outputData = 0;
    bool check = true;
    while (check)
    {
        while (!int.TryParse(Console.ReadLine(), out outputData))
        {
            System.Console.WriteLine("Невернвй ввод, Введите заново");
        }
        if (outputData <= 0)
        {
            System.Console.WriteLine("Введенное вами число не положительное. Повторите ввод");
        }
        else check = false;
    }
    return outputData;

}


double[,] GetMarixDouble(int row, int column, double maxElem)
{
    double[,] matrix = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = (double)rnd.NextDouble() * maxElem;

            if (rnd.Next(2) == 0 ? true : false)
                matrix[i, j] = -matrix[i, j];
        }
    }
    return matrix;
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"|{array[i, j],7}| ");
        }
        System.Console.WriteLine();
    }
}