// Напишите программу замены элементов массива: положитепльные элементы заменить на отриуательные и наоборот.

System.Console.WriteLine("Введите количество элементов в массиве");
int arraySize = checkingDataEntry();
System.Console.WriteLine("Введите начало обдасти случайных чисел");
int minValue = checkingDataEntry();
System.Console.WriteLine("Введите конец обдасти случайных чисел");
int maxValue = checkingDataEntry();
int[] array;
int[] reverseArray;


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

void printArray(int[] array)
{
    System.Console.Write(string.Join(", ", array));
}

int[] replacingArrayElements(int[] array)
{
    int endOfCycle = array.Length;
    int[] reverseArray = new int[endOfCycle];
    for (int i = 0; i < endOfCycle; i++)
    {
        reverseArray[i] = -array[i];
    }
    return reverseArray;
}

array = getArray(arraySize, minValue, maxValue);
reverseArray = replacingArrayElements(array);

System.Console.Write("Дан массив: ");
printArray(array);
System.Console.WriteLine();
System.Console.Write("Обратный массив: ");
printArray(reverseArray);



