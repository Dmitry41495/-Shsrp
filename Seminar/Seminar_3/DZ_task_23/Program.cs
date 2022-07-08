// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите целое число");

int number = 0;

while (!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("Неверный ввод, введите число заново!!!");
    }

int[] TableOfNumbersInACube (int number)
{
    int[] arrayCube;

     if (number > 0)
     {
        int sizeArray = number;
        arrayCube = new int[sizeArray];
        int indexArray = 0;
        for(int i=1; i <= number; i++)
        {
            arrayCube[indexArray] = i * i * i;
            indexArray++;
        }
     }
     else
     {
        int sizeArray = 2 - number;
        arrayCube = new int[sizeArray];
        int indexArray = 0;
        for(int i=1; i >= number; i--)
        {
            arrayCube[indexArray] = i * i * i;
            indexArray++;
        }
     }
     return arrayCube;
}

void PrintArray(int[] array)
{
   int repeat = array.Length;
    for(int i = 0; i < repeat; i++)
    {
        if (i < repeat - 1)
        {
            System.Console.Write($"{array[i]}, ");
        }
        else
        {
            System.Console.Write($"{array[i]}.");
        }
        
    }
}

PrintArray(TableOfNumbersInACube(number));

