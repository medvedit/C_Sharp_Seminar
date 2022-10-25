// Задача №1 в классе:__________________________________________________________
// Задайте двумерный массив размера m на n, и заполните его случайными целыми числами.

//  Console.WriteLine("Введите колличество строк: ");
//  int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите колличество столбцов: ");
//  int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 50);
// PrintArray(array);

// int [,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     int [,] result = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int [,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++) // GetLength обрашение к размеру, (0) - строки.
//     {
//         for (int j = 0; j < Array.GetLength(1); j++) // GetLength обрашение к размеру, (1) - столбцы.
//         {
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
    
// }

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

// Задача №3 в классе:_________________________________________________________________________________________________________________________________ ВЫ ПРОСИЛИ ДОИА ЭТО РЕШИТЬ!!!____________________________________________________________________________________________________
// Задайте двумерный массив размера m на n, инайдите среднее арифмитическое суммы углов в массиве.

// Console.WriteLine("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 5);
// PrintArray(array);
// Console.WriteLine($"Среднее арифметическое  = {AverageCorner(array)}");

// int AverageCorner (int[,] sumArray)
// {
//     int sum1 = sumArray[0,0] + sumArray[0,1] + sumArray[1,0];
//     int sum2 = sumArray[0, sumArray.GetLength(0) - 2] + sumArray[0, sumArray.GetLength(0) - 1] + sumArray[1, sumArray.GetLength(0) - 1];
//     int sum3 = sumArray[sumArray.GetLength(1) - 2, 0] + sumArray[sumArray.GetLength(1) - 1, 0] + sumArray[sumArray.GetLength(1) - 1, 1];
//     int sum4 = sumArray[sumArray.GetLength(0) - 1, sumArray.GetLength(1) - 1] + sumArray[sumArray.GetLength(0) - 1, sumArray.GetLength(1) - 2] + sumArray[sumArray.GetLength(0) - 2, sumArray.GetLength(1) - 1];
//     int corner = (sum1 + sum2 + sum3 + sum4) / 12;
//     return corner;
// }
// Ответ : Введите колличество строк: 
//         5
//         Введите колличество столбцов: 
//         5
//         0 3 5 1 2 
//         0 1 5 0 1 
//         2 5 3 1 5 
//         3 1 3 5 4 
//         4 4 3 1 5 
//         Среднее арифметическое  = 2




// Задача 4 в классе: __________________________________________________________________________________________________________
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.



// ПЕРВЫЙ ВАРИАНТ И ПЕЧАТЬ МАССИВА ИЗ МЕТОДА С РЕШЕНИЕМ__________

// Console.WriteLine("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 2, 5);
// PrintArray(array);
// Console.WriteLine();
// EvenIndexDegree(array);

// void EvenIndexDegree(int[,]degreeArray)
// {
//     for (int i = 0; i < degreeArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < degreeArray.GetLength(1); j++)
//         {
//             if(i %2 == 0 && j %2 == 0){
//                 degreeArray[i,j] *= degreeArray[i,j];
//                 Console.Write($"{degreeArray[i,j]} ");
//             }
//             else Console.Write($"{degreeArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

//ВТОРОЙ РАРИАНТ И ПЕЧАТЬ ИЗ МЕТОДА PrintArray(array);, ПОСЛЕ ЗАПРОСА МЕТОДА С РЕШЕНИЕМ _____________________

// Console.WriteLine("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 2, 5);
// PrintArray(array);
// Console.WriteLine();
// EvenIndexDegree(array);
// PrintArray(array);


// void EvenIndexDegree(int[,]degreeArray)
// {
//     for (int i = 0; i < degreeArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < degreeArray.GetLength(1); j++)
//         {
//             if(i %2 == 0 && j %2 == 0){
//                 degreeArray[i,j] *= degreeArray[i,j];
//             }
//         }
//     }
// }

//Задача 5 в классе___________________________________________________________________________________
//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Console.WriteLine("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 2, 5);
// Console.WriteLine();
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма всех элементов на  \"главной диагонали\" =  {SumOfElements(array)}");
// Console.WriteLine();


// int SumOfElements(int[,]sumElementsArray)
// {
//     int sum = 0;
//     for (int i = 0; i < sumElementsArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < sumElementsArray.GetLength(1); j++)
//         {
//             if(i == j){
//                 sum = sum + sumElementsArray[i,j];
//             }
//         }
//     }return sum;
// }


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------ДОМАШНЯЯ РАБОТА--------------------------------------------------------------------------------------------------------------------------------


// Задача 47: -------------------------------------------------------------------------------
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns);
PrintArray(array);


double[,] GetArray (int m, int n)
{
    Random rnd = new Random();
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/ 10.0);
        }
    }
    return result;
}

void PrintArray(double [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++) 
    {
        for (int j = 0; j < Array.GetLength(1); j++) 
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}
// Ответ: Введите колличество строк: 
//        3
//        Введите колличество столбцов: 
//        4
//        9,4 -8,5 -9,5 -0,3 
//        -2,4 4,1 2,9 1,9 
//        0,1 -3,3 -3,9 9,5 




