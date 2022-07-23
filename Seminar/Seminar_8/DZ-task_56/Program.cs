// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк двумерного массива:");
int rowsNumber = CheckingForIntPositive();
Console.WriteLine("Введите количество столбцов двумерного массива:");
int columnNumber = CheckingForIntPositive();
Console.WriteLine("Введите минимальное значение элемента массива:");
int minEl = CheckingForInt();
Console.WriteLine("Введите максимальное значение элемента массива:");
int maxEl = CheckingForMax(minEl);

int[,] matrix = GetMarix(rowsNumber, columnNumber, minEl, maxEl);
Console.WriteLine("Исходная матрица: ");
PrintMatrix(matrix);
Console.WriteLine($"{FindRowWithMinSum(matrix)} строка имеет минимальную сумму элементов");




int CheckingForInt()
{
    int outputData = 0;
    while (!int.TryParse(Console.ReadLine(), out outputData))
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

int CheckingForMax(int minNumber)
{
    int maxNumber = minNumber;
    bool check = true;
    while (check)
    {
        while (!int.TryParse(Console.ReadLine(), out maxNumber))
        {
            System.Console.WriteLine("Невернвй ввод, Введите заново");
        }
        if (maxNumber <= minNumber)
        {
            System.Console.WriteLine("Введенное вами число меньше или равно минимальному. Повторите ввод!");
        }
        else check = false;
    }
    return maxNumber;
}


int[,] GetMarix(int row, int column, int minElem, int maxElem)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rnd.Next(minElem, maxElem + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] array)
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


int FindRowWithMinSum(int[,] mtrx)
{
    int lastLine = mtrx.GetLength(0);
    int lastСolumn = mtrx.GetLength(1);
    int sum = 0;
    int sumMin = 0;
    int lineNumber = 0;
    for (int i = 0; i < lastСolumn; i++)
    {
        sumMin += mtrx[0, i];
    }
    for (int i = 1; i < lastLine; i++)
    {
        for (int j = 0; j < lastСolumn; j++)
        {
            sum += mtrx[i, j];
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            lineNumber = i+1;
        }
        sum = 0;
    }
    return lineNumber;
}


