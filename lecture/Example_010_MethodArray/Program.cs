int[] array = {1, 58, 78, 67, 58, 78, 56, 58};

int n = array.Length;
int finde = 58;
int index = 0;

while (index < n)
{
    index++;
    if (array[index] == finde)
    {
       
        Console.WriteLine(index);
        break;
    }
}