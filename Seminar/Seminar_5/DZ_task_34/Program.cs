// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

System.Console.WriteLine("Введите количество элементов в массиве");
int arraySize = checkingDataEntry();
int minValue = 100;
int maxValue = 999;
int[] array;


array = getArray(arraySize, minValue, maxValue);
System.Console.WriteLine($"Дан массив: {string.Join(", ", array)}, в нем содержится {numberOfEvenNumbers(array)} четных чисел");



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

int numberOfEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int elem in array)
    {
        count += elem % 2 == 0 ? 1 : 0;
    }
    return count;
}

