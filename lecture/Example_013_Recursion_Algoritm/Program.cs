// Двумерный массив


// string[,] table = new string[2, 5];

// for(int rows = 0; rows < 2; rows++)
// {
//     for(int column = 0; column < 5; column++)
//     {
//         Console.WriteLine($"-{table[rows, column]}-");
//     }
// }

// void  PrintArray(int[,] matrix)
// {
//     for(int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for(int column = 0; column < matrix.GetLength(1); column++)
//         {
//             Console.Write($"{matrix[rows, column]} ");
//         }
//         Console.WriteLine();
//     }
// }


// void FillArray(int[,] matrix)
// {
//     int numbers;
//     for(int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for(int column = 0; column < matrix.GetLength(1); column++)
//         {
//            while (!int.TryParse(Console.ReadLine(), out numbers))
//             {
//                  System.Console.WriteLine("Неверный ввод, введите число заново!");
//             }
//             matrix[rows, column] = numbers;
//         }
//     }
// }

// int[,] matrix = new int[3, 5];

// PrintArray(matrix);

// FillArray(matrix);

// PrintArray(matrix);

// void  PrintImage(int[,] image)
// {
//     for(int rows = 0; rows < image.GetLength(0); rows++)
//     {
//         for(int column = 0; column < image.GetLength(1); column++)
//         {
//             if(image[rows, column] == 0)
//             {
//                 Console.Write(" ");
//             }
//             else
//             {
//                 Console.Write("+");
//             }
            
//         }
//         Console.WriteLine();
//     }
// }

// int[,] pic = new int[,]
// {
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void FillImage(int row, int column)
// {
//     if (pic[row, column] == 0)
//     {
//         pic[row, column] = 1;
//         FillImage(row - 1, column);
//         FillImage(row, column - 1);
//         FillImage(row + 1, column);
//         FillImage(row, column + 1);
//     }
// }



// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);



// double Factorial(int n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
    
// }


// for(int i = 1; i<40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// f(1) =1
// f(2) = 1
// f(n) = f(n-1) +f(n-2)

int Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

Console.WriteLine(Fibonacci(4));







