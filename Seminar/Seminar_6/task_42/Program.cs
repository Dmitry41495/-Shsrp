// Напишите число, которое будет преобразовывать деситичное числов двоичное

System.Console.WriteLine("Введите целое, десятичное число");

int decimalNumber = CheckingDataEntry();


int CheckingDataEntry()
{
    int outputData;
    while (!int.TryParse(Console.ReadLine(), out outputData))
    {
        System.Console.WriteLine("Неверный ввод, введите число заново!");
    }
    return outputData;
}


string ConvertToBinary(int number)
{
   string binaryNumber = "";
   while (number > 1)
   {
        binaryNumber = binaryNumber + number % 2;
        number = number / 2;
   }
   binaryNumber = binaryNumber + 1; 

   for(int i =0; i < binaryNumber.Length; i++)
   
   return binaryNumber;
}


System.Console.WriteLine(ConvertToBinary(decimalNumber));