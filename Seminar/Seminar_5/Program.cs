// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.



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

int[] createArray(int arrayLength, int minValue, int maxValue + 1)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int array[] = createArray(12, -9, 9);

// int sumNumbersParametric(int[] array, bool findPositiveNumbers = true)
// {
//     int sum = 0;
//     foreach ( int elem in array )
//     {
//         if(findPositiveNumbers)
//         {
//             sum += elem > 0 ? elem : 0;
//         }
//         else
//         {
//             sum += elem < 0 ? elem : 0;
//         }
//     }
//     return sum;
// }


void printArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write(string.Join("," array));
    }
}


Console.WriteLine(printArray(createArray(arrayLength))));


