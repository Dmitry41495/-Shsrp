// Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

int number;
int i = 0;

System.Console.WriteLine("Введите число");

while (! int.TryParse(Console.ReadLine(), out number))
    {
    System.Console.WriteLine("Неверный ввод, введите число заново!!!");
    }

string numberToString = Convert.ToString(number);
int numberOfDigits = numberToString.Length;

if (numberOfDigits < 3)
    {
        System.Console.WriteLine("В данном числе нет третьей цыфры");
    }

    else    
    {
        while (i < numberOfDigits - 3)
        {
            number = number / 10;
            i++;
        }
     System.Console.WriteLine($"третья цифра данного фисла: {Math.Abs(number % 10)}");        
    }


