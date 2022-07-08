

int GetSum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
System.Console.WriteLine(GetSum(num));

int GetSumFast(int a)
{
   return a * (a + 1) / 2;
}

System.Console.WriteLine(GetSum(num));