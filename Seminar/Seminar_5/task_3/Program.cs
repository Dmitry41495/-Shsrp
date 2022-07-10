// Задайте массив. Напишите программу которвя определяет, присутсвует ли данное число в массиве.
System.Console.WriteLine("Введите количество элементов в массиве");
int arraySize = checkingDataEntry();
System.Console.WriteLine("Введите начало обдасти случайных чисел");
int minValue = checkingDataEntry();
System.Console.WriteLine("Введите конец обдасти случайных чисел");
int maxValue = checkingDataEntry();
System.Console.WriteLine("Введите число, которое нужно искать в массиве: ");
int desiredNumber = checkingDataEntry();
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

bool checkNumberInArray(int[] array, int number)
{
    bool ifFound = false;
    foreach(int elem in array)
    {
        if (number == elem)
        {
            ifFound = true;
            break;
        }
    }
   return ifFound;
}

array = getArray(arraySize, minValue, maxValue);


if (checkNumberInArray(array, desiredNumber) == true)
{
    System.Console.WriteLine($"число {desiredNumber} встречается в массиве {string.Join(", ", array)}");
}
else
{
     System.Console.WriteLine($"число {desiredNumber} не встречается в массиве {string.Join(", ", array)}");
}

