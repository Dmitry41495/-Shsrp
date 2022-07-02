// Вид 1
void Method1()
{
    System.Console.WriteLine("Автор...");
}

//Method1();









// Вид 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);     
}

//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
    
}

//Method21(msg: "Текст сообщения", count: 4);
//Method21(count: 4, msg: "Текст ");











// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//System.Console.WriteLine(year);






// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string resault = String.Empty;

//     while (i < count)
//     {
//         resault = resault + text;
//         i++;
//     }
//     return resault;
// }

// string res = Method4(10, "z");
// System.Console.WriteLine(res);


// string Method4(int count, string text)
// {
   
//     string resault = String.Empty;

//     for( int i =0; i < count; i++)
//     {
//         resault = resault + text;
//     }
//     return resault;
// }

// string res = Method4(10, "z");
// System.Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//     for(int j=2; j <=10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     System.Console.WriteLine();
// }



//======= Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// малкникие буквы "к" заменить болишими буквами "К",
// ф брльшие буквы "С" заменить маленикми "с".

string text = "- Я думаю, - сказал князь, улыбвюсь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде, "
            + "вы бы ызяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345 
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string resault = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) resault = resault + $"{newValue}";
//         else resault = resault + $"{text[i]}";  
        
//     }
//     return resault;

// }

// string newText = Replace(text,' ','|');
// System.Console.WriteLine(newText);
// newText = Replace(newText,'к','К');
// System.Console.WriteLine(newText);
// newText = Replace(newText,'С','с');
// System.Console.WriteLine(newText);


int[] arr = {8, 45, 3, 8, 12, 0, 44};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

PrintArray(arr);

void SelectionSort(int[] array)
{
    for(int i=0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j=i+1; j < array.Length; j++)
        {
            if(array[minPosition] > array[j]) minPosition = j;
        }    
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
    }
}


SelectionSort(arr);

PrintArray(arr);


void SelectionSortReverse(int[] array)
{
    for(int i=0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for(int j=i+1; j < array.Length; j++)
        {
            if(array[maxPosition] < array[j]) maxPosition = j;
        }    
    int temp = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temp;
    }
}

SelectionSortReverse(arr);

PrintArray(arr);