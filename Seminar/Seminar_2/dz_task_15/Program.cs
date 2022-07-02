// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите цифру соответсвующую дню недели, где:");
System.Console.WriteLine("1 - понедельник");
System.Console.WriteLine("2 - вторник");
System.Console.WriteLine("3 - среда");
System.Console.WriteLine("4 - четверг");
System.Console.WriteLine("5 - пятница");
System.Console.WriteLine("6 - суббота");
System.Console.WriteLine("7 - воскресенье");

int i = 0;
int day = 0;

while(i == 0)
    {
    while (! int.TryParse(Console.ReadLine(), out day))
        {
        System.Console.WriteLine("Неверный ввод, введите цифру заново!!!");
        }    

    if (day > 0 && day < 8) i++;
    else System.Console.WriteLine("Неверный ввод, введите цифру заново!!!");
    }

void PrintCheckingForADayOff(int day)
{
    switch (day)
    {
    case 1: Console.WriteLine("понедельник - будний день"); break;
    case 2: Console.WriteLine("вторник - будний день"); break;
    case 3: Console.WriteLine("среда - будний день"); break;
    case 4: Console.WriteLine("четверг - будний день"); break;
    case 5: Console.WriteLine("пяьница - будний день"); break;
    case 6: Console.WriteLine("суббота - выходной день"); break;
    case 7: Console.WriteLine("воскресенье - выходной день"); break;
    }
}

PrintCheckingForADayOff(day);





