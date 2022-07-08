//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("ВВедите пятизначное число");

bool breakWhile = false;
int palindrome = 0;

//Проверяем правильность ввода целого пятизначного числа:

while (breakWhile == false)
{
    while (!int.TryParse(Console.ReadLine(), out palindrome))
    {
        System.Console.WriteLine("Неверный ввод, введите число заново!!!");
    }
    if (palindrome < 100000 && palindrome > 9999)
    {
        breakWhile = true;
    }
    else
    {
        System.Console.WriteLine("Неверный ввод, введите число заново!!!");
    }
}

//Проверка на палиндром, вариант первый:

void checkingForAPalindrome_1(int palindrome)
{
    if (
        palindrome / 10000 == palindrome % 10 &&
        (palindrome % 10000) / 1000 == (palindrome % 100) / 10
        )
    {
        System.Console.WriteLine("Веденное число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Веденное число не является палиндромом");
    }
}


//Проверка на палиндром, вариант второй:

void checkingForAPalindrome_2(int palindrome)
{
    string stringPalindrome = Convert.ToString(palindrome);
    if (
        stringPalindrome[0] == stringPalindrome[4] &&
        stringPalindrome[1] == stringPalindrome[3]
        )
    {
        System.Console.WriteLine("Веденное число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Веденное число не является палиндромом");
    }
}


//Проверка на палиндром, вариант третий:

void checkingForAPalindrome_3(int palindrome)
{
    string stringPalindrome = Convert.ToString(palindrome);
    if (
        stringPalindrome[0] + stringPalindrome[1] ==
        stringPalindrome[4] + stringPalindrome[3]
        )
    {
        System.Console.WriteLine("Веденное число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Веденное число не является палиндромом");
    }
}


checkingForAPalindrome_1(palindrome);
System.Console.WriteLine();
checkingForAPalindrome_2(palindrome);
System.Console.WriteLine();
checkingForAPalindrome_3(palindrome);
