// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// результат запишите в новом массиве

System.Console.WriteLine("Введите количество элементов в массиве");
int arraySize = checkingDataEntry();
System.Console.WriteLine("Введите начало области случайных чисел");
int minValue = checkingDataEntry();
System.Console.WriteLine("Введите конец области случайных чисел");
int maxValue = checkingDataEntry();
int[] array;




int checkingDataEntry()
{
    int outputData;
    while (!int.TryParse(Console.ReadLine(), out outputData))
    {
        System.Console.WriteLine("Неверный ввод, введите число заново!");
    }
    return outputData;
}

int[] getArray(int arraySize, int minValue, int maxValue)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] productOfPairsOfElements(int[] array)
{
    int sizArray = array.Length;
    if (arraySize % 2 > 0)
    {
        int[] arrayOfProductsOfNumbers = new int[arraySize / 2 + 1];

        for (int i = 0; i < sizArray / 2; i++)
        {
            arrayOfProductsOfNumbers[i] = array[i] * array[arraySize - i - 1];
        }
        arrayOfProductsOfNumbers[arraySize/2] = array[arraySize / 2];
        return arrayOfProductsOfNumbers;
    }
    else
    {
       int[] arrayOfProductsOfNumbers = new int[arraySize / 2];

        for (int i = 0; i < sizArray / 2; i++)
        {
            arrayOfProductsOfNumbers[i] = array[i] * array[arraySize - i - 1];
        }
        return arrayOfProductsOfNumbers;
    }
    
}

array = getArray(arraySize, minValue, maxValue);

System.Console.WriteLine($"Дан массив: {string.Join(", ", array)}");
System.Console.WriteLine($"Gроизведение пар чисел в нем равно: {string.Join(", ", productOfPairsOfElements(array))}");