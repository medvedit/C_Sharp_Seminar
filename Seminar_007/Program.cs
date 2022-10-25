// Задача №1 в классе:__________________________________________________________
// Задайте двумерный массив размера m на n, и заполните его случайными целыми числами.

//  Console.WriteLine("Введите колличество строк: ");
//  int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите колличество столбцов: ");
//  int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 50);
// PrintArray(array);

int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int [,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++) // GetLength обрашение к размеру, (0) - строки.
    {
        for (int j = 0; j < Array.GetLength(1); j++) // GetLength обрашение к размеру, (1) - столбцы.
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}

// Задача №2 в классе:__________________________________________________________
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: A[,] = m+n. 
// Выведите полученный массив на экран.

// Console.WriteLine("Введите колличество строк: ");
//  int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите колличество столбцов: ");
//  int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray2(rows, columns, 0, 5);
// PrintArray(array);

// int [,] GetArray2 (int m, int n, int minValue, int maxValue)
// {
//     int [,] result = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = i + j;
//         }
//     }
//     return result;
//  }

 // Ответ: Введите колличество строк: 
//         5
//         Введите колличество столбцов: 
//         5
//         0 1 2 3 4 
//         1 2 3 4 5 
//         2 3 4 5 6 
//         3 4 5 6 7 
//         4 5 6 7 8  

// Задача №3 в классе:__________________________________________________________
// Задайте двумерный массив размера m на n, инайдите среднее арифмитическое суммы углов в массиве.

Console.WriteLine("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 5);
PrintArray(array);
Console.WriteLine($"Среднее арифметическое  = {AverageCorner(array)}");

int AverageCorner (int[,] sumArray)
{
    int sum1 = sumArray[0,0] + sumArray[0,1] + sumArray[1,0];
    int sum2 = sumArray[0, sumArray.GetLength(0) - 2] + sumArray[0, sumArray.GetLength(0) - 1] + sumArray[1, sumArray.GetLength(0) - 1];
    int sum3 = sumArray[sumArray.GetLength(1) - 2, 0] + sumArray[sumArray.GetLength(1) - 1, 0] + sumArray[sumArray.GetLength(1) - 1, 1];
    int sum4 = sumArray[sumArray.GetLength(0) - 1, sumArray.GetLength(1) - 1] + sumArray[sumArray.GetLength(0) - 1, sumArray.GetLength(1) - 2] + sumArray[sumArray.GetLength(0) - 2, sumArray.GetLength(1) - 1];
    int corner = (sum1 + sum2 + sum3 + sum4) / 4;
    return corner;
}
// Ответ : Введите колличество строк: 
//         5
//         Введите колличество столбцов: 
//         5
//         5 1 2 5 4 
//         1 5 1 5 2 
//         4 0 4 4 5 
//         1 2 4 2 3 
//         4 1 0 4 0 
//         Среднее арифметическое  = 7


