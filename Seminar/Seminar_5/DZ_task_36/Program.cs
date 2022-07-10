// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

System.Console.WriteLine("Введите количество элементов в массиве");
int arraySize = checkingDataEntry();
System.Console.WriteLine("Введите начало области случайных чисел");
int minValue = checkingDataEntry();
System.Console.WriteLine("Введите конец области случайных чисел");
int maxValue = checkingDataEntry();


int[] array = getArray(arraySize, minValue, maxValue);
System.Console.WriteLine($"Дан массив: {string.Join(", ", array)}");
System.Console.WriteLine($"Сумма элементов стоящих на нечентых позициях = {sumOfElementsInOddPositions(array)}");


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

int sumOfElementsInOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

