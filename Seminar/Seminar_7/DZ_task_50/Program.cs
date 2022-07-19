//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


System.Console.WriteLine("Введите количество строк двумерного массива:");
int rowsNumber = CheckingForIntPositive();
System.Console.WriteLine("Введите количество столбцов двумерного массива:");
int columnNumber = CheckingForIntPositive();
System.Console.WriteLine("Введите минимальное значение элемента массива:");
int minEl = CheckingForInt();
System.Console.WriteLine("Введите максимальное значение элемента массива:");
int maxEl = CheckingForMax(minEl);
System.Console.WriteLine("Введите индекс строки искомого элемента");
int rowIndex = CheckingForInt();
System.Console.WriteLine("Введите индекс столбца искомого элемента");
int columnIndex = CheckingForInt();

int[,] matrix = GetMarix(rowsNumber, columnNumber, minEl, maxEl);
System.Console.WriteLine("Дан массив вида:");
PrintArray(matrix);
ReturnElemByIndex(matrix, rowIndex, columnIndex);





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

void ReturnElemByIndex(int[,] mtrx, int rowInd, int colInd)
{
    if (rowInd < mtrx.GetLength(0) && colInd < mtrx.GetLength(1))
    {
        System.Console.WriteLine($"Элемент масива с  индексами {rowInd} и {colInd} = {mtrx[rowInd, colInd]}");
    }
    else
    {
        System.Console.WriteLine($"Элемента с  индексами {rowInd} и {colInd} в данном массиве нет!");
    }

}
