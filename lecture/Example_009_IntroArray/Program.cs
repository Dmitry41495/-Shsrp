int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2; 
    if (arg3 > result) result = arg3;
    return result;
}

int [] array = {1, 2, 3, 170, 5, 1000, 59, 3, 9};


int MaxFinal = Max(
    Max(array[1], array[2], array[3]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(MaxFinal);

