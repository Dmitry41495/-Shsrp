// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

System.Console.WriteLine("Введите количество элементов в массиве");
int arraySize = checkingDataEntry();

System.Console.WriteLine("Введите верхнюю границу области получения элементов массива");
int border = checkingDataEntry();


double[] array = getArray(arraySize);
System.Console.WriteLine($"Дан массив вещественных чисел {string.Join(", ", array)}");
System.Console.WriteLine($"Разница между максимальним и минимальным элеметом массива = {findMaxElem(array) - findMinElem(array)}");




int checkingDataEntry()
{
    int outputData;
    while (!int.TryParse(Console.ReadLine(), out outputData))
    {
        System.Console.WriteLine("Неверный ввод, введите число заново!");
    }
    return outputData;
}

double[] getArray(int arraySize)
{
    double[] array = new double[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().NextDouble() * border;
    }
    return array;
}


double findMaxElem(double[] array)
{
    double maxElem = double.MinValue;
    foreach (double elem in array)
    {
        maxElem = elem > maxElem ? elem : maxElem;
    }
    return maxElem;

}

double findMinElem(double[] array)
{
    double minElem = double.MaxValue;
    foreach (double elem in array)
    {
        minElem = elem < minElem ? elem : minElem;
    }
    return minElem;

}

