// Задайте ожномерный массив из 123 сдучайных чисел, найдите кол-во двухзначных элементов в массиве.
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

int[] getArray(int sizeArray, int minValue, int maxValue)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int findTwoDigit(int[] array)
{
    int countTwoDigit = 0;
    foreach(int elem in array)
    {
        countTwoDigit += elem < 100 && elem > 9? 1 : 0;
    }
    return countTwoDigit;
}

array = getArray(arraySize, minValue, maxValue);
System.Console.WriteLine($"В массиве {string.Join(", ", array)}");
System.Console.WriteLine($"Имеется {findTwoDigit(array)} двухзначных элементов");