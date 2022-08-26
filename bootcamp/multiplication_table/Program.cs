// Таблица умножения

int n =5;
int [,] matrix = new int [n, n];
for(int i =1; i<=n; i++)
{
    for(int j=1; j<=n; j++)
    {
        Console.Write($"{j*i} \t");
    }
    Console.WriteLine();
}

for(int i =0; i<n; i++)
{
    for(int j=i; j<n; j++)
    {
        if(i+j<=n)
        {
            matrix[i,j]=(i+1)*(j+1);
            matrix[j,i]=(i+1)*(j+1);
        }
    }
    Console.WriteLine();
}

for(int i =0; i<n; i++)
{
    for(int j=0; j<n; j++)
    {
        Console.Write($"{matrix[i,j]} \t");
    }
    Console.WriteLine();
}


