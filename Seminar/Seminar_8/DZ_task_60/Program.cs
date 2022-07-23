// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента

Console.WriteLine("Введите длину трехмерного массива:");
int cubeLength = CheckingForIntPositive();
Console.WriteLine("Введите ширину трехмерного массива:");
int cubeWidth = CheckingForIntPositive();
Console.WriteLine("Введите высоту трехмерного массива:");
int cubeHeight = CheckingForIntPositive();

int[,,] array = new int[cubeLength, cubeWidth, cubeHeight];

array = FillCube(cubeLength, cubeWidth, cubeHeight);

PrintCube(array);

int CheckingForIntPositive()
{
    int outputData = 0;
    bool check = true;
    while (check)
    {
        while (!int.TryParse(Console.ReadLine(), out outputData))
        {
            Console.WriteLine("Невернвй ввод, Введите заново");
        }
        if (outputData <= 0)
        {
            Console.WriteLine("Введенное вами число не положительное. Повторите ввод");
        }
        else check = false;
    }
    return outputData;

}


int[,,] FillCube(int length, int width, int height)
{
    int[] collection = new int[length * width * height];
    
    Random rnd = new Random();
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        collection[i] = rnd.Next(10, 100);
               
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (collection[i] == collection[j])
                {
                    collection[i] = rnd.Next(10, 100);
                    j = 0;
                }
            }
        }

        int count = 0;
        for (int i1 = 0; i1 < length; i1++)
        {
            for (int j = 0; j < width; j++)
            {
                for (int k = 0; k < height; k++)
                {
                    array[i1, j, k] = collection[count];
                    count++;
                }
            }
        }
    }
    return array;
}


void PrintCube(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

