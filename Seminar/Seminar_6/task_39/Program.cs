// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте а первый на последнем месте)

Console.WriteLine("Введите длину массива");
int sizeArray = CheckingDataEntry();

int[] array = GetArray(sizeArray);

Console.WriteLine("Дан массив:");

PrintArray(array);

Console.WriteLine();

Console.WriteLine("Обратный ему массив имеет вид: ");

PrintArray(ReverseArray(array));


int[] GetArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    for(int i = 0; i < sizeArray; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
   System.Console.WriteLine(string.Join(",", array)); ;
}

int CheckingDataEntry()
{
    int outputData;
    while (!int.TryParse(Console.ReadLine(), out outputData))
    {
        System.Console.WriteLine("Неверный ввод, введите число заново!");
    }
    return outputData;
}

int[] ReverseArray(int[] array)
{
    int j = array.Length-1;
    int temp;
    for(int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        j--;
    }
    return array;
}


