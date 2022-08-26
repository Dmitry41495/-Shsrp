// Сортировка выбором

/*
[6, 15, 2, 9, -3]
min=6
6<15
6>2
min=2
2<9
2>-3
min=-3
[-3, 6, 15, 2, 9]
[6, 15, 2, 9]
min=6
6<15
6>2
nin=2
2<9
[-3, 2, 6, 15, 2, 9]
[6, 15, 2, 9]
...
*/

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите  элемент");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i=0; i<array.Length; i++)
{
    Console.Write($"{array[i]} " );
}

for(int i=0; i<n; i++)
{
    int minIndex = i;
    for (int j=i+1; j<n; j++)
    {
        if(array[j]<array[minIndex])
        minIndex = j;
    }
    int temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;

}

System.Console.WriteLine();

for(int i=0; i<array.Length; i++)
{
    Console.Write($"{array[i]}" );
}
