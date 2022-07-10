// Задйте массив из 12 элементов, заполненый случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива

System.Console.WriteLine("Введите количество элементов в массиве");
int arraySize = checkingDataEntry();
System.Console.WriteLine("Введите начало обдасти случайных чисел");
int minValue = checkingDataEntry();
System.Console.WriteLine("Введите конец обдасти случайных чисел");
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

void printArray(int[] array)
{
   System.Console.WriteLine(string.Join(",", array));
}

int sumNumberParametric(int[] array, bool findPositivNumbers = true)
{
    int sum = 0;
    foreach(var elem in array )
    {
        if(findPositivNumbers)
        {
            sum += elem > 0? elem : 0;
        }
        else
        {
            sum += elem < 0? elem : 0;
        }
    }
    return sum;
}

array = getArray(arraySize, minValue, maxValue);

System.Console.Write($"Задан массив  из {arraySize} элементов: ");
printArray(array);


System.Console.Write("Сумма полождительных элементов массива: ");
System.Console.WriteLine(sumNumberParametric(array));
System.Console.Write("Сумма отрицательных элементов массива: ");
System.Console.WriteLine(sumNumberParametric(array, false));

