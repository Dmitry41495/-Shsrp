// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

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

int[] createArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}


void printArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (i == size - 1)
        {
            System.Console.Write($"{array[i]}.");
        }
        else
        {
            System.Console.Write($"{array[i]}, ");
        }

    }
}

printArray(createArray(arrayLength));





