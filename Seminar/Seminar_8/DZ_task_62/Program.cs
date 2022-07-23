//  Заполните спирально массив 4 на 4.

int arrayLength = 6;
int arrayWidth = 6;

int[,] array = new int[arrayLength, arrayWidth];

PrintMatrix(
    SpiralFilling(array)
);



int[,] SpiralFilling(int[,] array)
{
    int count = 1;
    int arraySize = array.GetLength(0);
    for (int i = 0; i < arraySize / 2; i++)
    {
        for (int j = i; j < arraySize - i; j++)
        {
            array[i, j] = count++;
        }
        for (int k = i + 1; k < arraySize - i; k++)
        {
            array[k, arraySize - 1 - i] = count++;
        }
        for (int n = arraySize - 2 - i; n > i; n--)
        {
            array[arraySize - 1 - i, n] = count++;
        }
        for (int m = arraySize - 1 - i; m > i; m--)
        {
            array[m, i] = count++;
        }
    }
    return array;
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


