// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]


System.Console.WriteLine("Введите длну массива");

int arrayLength = 0;

for (bool i = false; i == false;)
{
    while (!int.TryParse(Console.ReadLine(), out arrayLength))
    {
        System.Console.WriteLine("Неверный ввод, введите степень заново!");
    }
    if (arrayLength > 0)
    {
        i = true;
    }
    else
    {
        System.Console.WriteLine("Неверный ввод, введите степень заново!");
    }
}

int[] createArray(int arrayLength, int maxValue, int minValue)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(maxValue, minValue +1);
    }
    return array;
}


void printArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(string.Join("," array))
    }
}

void replaceElements (int[] array)
{
    foreach(int elem in array)
    {
        elem = - elem;
    }
    
}

int[] array = createArray(arrayLength, 9, -9);

Console.WriteLine(printArray(array));

Console.WriteLine(printArray(replaceElements(array)));

Console.WriteLine("clkwjc");