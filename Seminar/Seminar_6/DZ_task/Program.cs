// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.WriteLine("Введите кол-во числе, которые собираетесь вводить:");

int numberOfNumbers = CheckingDataEntryPositive();

int[] array = GetArrayOfNumbers(numberOfNumbers);

System.Console.WriteLine(
    $"Среди данных чисел ({string.Join(", ", array)})  {CountPositive(array)} положительных"
);

int[] GetArrayOfNumbers(int numberOfNumbers)
{
    int[] arrayOfNumbers = new int[numberOfNumbers];
    for (int i = 0; i < numberOfNumbers; i++)
    {
        arrayOfNumbers[i] = CheckingDataEntry();
    }
    return arrayOfNumbers;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

int CheckingDataEntryPositive()
{
    int outputData = 0;
    bool trigger = false;
    while (trigger == false)
    {
        while (!int.TryParse(Console.ReadLine(), out outputData))
        {
            System.Console.WriteLine("Неверный ввод, введите число заново!");
        }
        if (outputData > 0)
        {
            trigger = true;
        }
        else
        {
            System.Console.WriteLine("Неверный ввод, введите длину заново!!");
        }
    }
    return outputData;
}

int CheckingDataEntry()
{
    int outputData = 0;

    {
        while (!int.TryParse(Console.ReadLine(), out outputData))
        {
            System.Console.WriteLine("Неверный ввод, введите число заново!");
        }
    }
    return outputData;
}
