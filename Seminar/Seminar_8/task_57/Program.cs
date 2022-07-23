// Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных.

System.Console.WriteLine("Введите количество строк двумерного массива:");
int rowsNumber = CheckingForIntPositive();
System.Console.WriteLine("Введите количество столбцов двумерного массива:");
int columnNumber = CheckingForIntPositive();
System.Console.WriteLine("Введите минимальное значение элемента массива:");
int minEl = CheckingForInt();
System.Console.WriteLine("Введите максимальное значение элемента массива:");
int maxEl = CheckingForMax(minEl);

int[,] matrix = GetMarix(rowsNumber, columnNumber, minEl, maxEl);
System.Console.WriteLine("Дана матрица: ");
PrintMatrix(matrix);
System.Console.WriteLine("Матрица после замены строк на столбцы: ");
PrintFrequencyDictionary(matrix);




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


void PrintFrequencyDictionary(int[,] mtrx)
{
    int lastLine = mtrx.GetLength(0);
    int lastColumn = mtrx.GetLength(1);
    int[] frequencyDictionary = new int[10];
    for (int i = 0; i < lastLine; i++)
    {
        for (int j = 0; j < lastColumn; j++)
        {
            switch (mtrx[i, j])
             {
                case 0: frequencyDictionary[0]++; break;
                case 1: frequencyDictionary[1]++; break;
                case 2: frequencyDictionary[2]++; break;
                case 3: frequencyDictionary[3]++; break;
                case 4: frequencyDictionary[4]++; break;
                case 5: frequencyDictionary[5]++; break;
                case 6: frequencyDictionary[6]++; break;
                case 7: frequencyDictionary[7]++; break;
                case 8: frequencyDictionary[8]++; break;
                case 9: frequencyDictionary[9]++; break;
            }
        }
    }
   for(int i = 0; i<frequencyDictionary.Length; i++)
   {
    Console.WriteLine($"{i} встречается {frequencyDictionary[i]} раз.");
   }
}