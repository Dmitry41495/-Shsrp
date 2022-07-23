//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк первой матрицы:");
int rowsNumber1 = CheckingForIntPositive();
Console.WriteLine("Введите количество столбцов первой матрицы:");
int columnNumber1 = CheckingForIntPositive();
Console.WriteLine("Введите минимальное значение элемента первой матрицы:");
int minEl1 = CheckingForInt();
Console.WriteLine("Введите максимальное значение элемента первой матрицы:");
int maxEl1 = CheckingForMax(minEl1);

Console.WriteLine("Введите количество строк первой матрицы:");
int rowsNumber2 = CheckingForIntPositive();
Console.WriteLine("Введите количество столбцов первой матрицы:");
int columnNumber2 = CheckingForIntPositive();
Console.WriteLine("Введите минимальное значение элемента первой матрицы:");
int minEl2 = CheckingForInt();
Console.WriteLine("Введите максимальное значение элемента первой матрицы:");
int maxEl2 = CheckingForMax(minEl2);



int[,] matrix1 = GetMarix(rowsNumber1, columnNumber1, minEl1, maxEl1);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix1);
int[,] matrix2 = GetMarix(rowsNumber2, columnNumber2, minEl2, maxEl2);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrix2);
Console.WriteLine("Их произведене равно: ");
PrintMatrix(
    ProductOfMatrices(matrix1, matrix2)
);


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
            Console.WriteLine("Невернвй ввод, Введите заново");
        }
        if (outputData <= 0)
        {
            Console.WriteLine("Введенное вами число не положительное. Повторите ввод");
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
            Console.WriteLine("Невернвй ввод, Введите заново");
        }
        if (maxNumber <= minNumber)
        {
            Console.WriteLine("Введенное вами число меньше или равно минимальному. Повторите ввод!");
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ProductOfMatrices(int[,] mtrx1, int[,] mtrx2)
{
    int[,] productOfMatrices = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];
    if (mtrx1.GetLength(1) == mtrx2.GetLength(0))
    {
        for (int i = 0; i < mtrx1.GetLength(0); i++)
        {
            for (int j = 0; j < mtrx2.GetLength(1); j++)
            {
                for (int k = 0; k < mtrx1.GetLongLength(1); k++)
                {
                    productOfMatrices[i, j] += mtrx1[i, k] * mtrx2[k, j];
                }
            }
        }

    }
    else
    {
        Console.WriteLine("Данные матрицы нельзя перемножить");
    }
    return productOfMatrices;
}
