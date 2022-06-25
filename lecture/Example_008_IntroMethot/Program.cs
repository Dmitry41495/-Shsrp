int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2; 
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 108;
int c1 = 4;
int a2 = 6;
int b2 = 13;
int c2 = 18;
int a3 = 19;
int b3 = 63545654;
int c3 = 1200;

//int Max1 = Max(a1, b1, c1);
//int Max2 = Max(a2, b2, c2);
//int Max3 = Max(a3, b3, c3);
int MaxFinal = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(MaxFinal);