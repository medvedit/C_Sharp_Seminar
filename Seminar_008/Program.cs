// // //Задача 53:_____________________________________________________________________________________________________________________
// //Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 10, 50);
// PrintArray(array);
// Console.WriteLine();
// ArrayTurn(array);
// PrintArray(array);


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// void ArrayTurn(int[,] Arr)
// {
//     for (int j = 0; j < Arr.GetLength(1); j++)
//     {
//         int temp = Arr[0, j];
//         Arr[0, j] = Arr[Arr.GetLength(0) - 1, j];
//         Arr[Arr.GetLength(0) - 1, j] = temp;
//     }
// }
// //Ответ: Введите колличество строк: 4
// //       Введите колличество столбцов: 4
// //       40 20 24 14 
// //       21 39 29 45 
// //       20 11 30 34 
// //       33 26 18 22 

// //       33 26 18 22 
// //       21 39 29 45 
// //       20 11 30 34 
// //       40 20 24 14 

// int temp = arr[i];  // обьявляем временную переменную temp и зпносим в нее значение arr[i], а вначале цикла for это = int i = 0 .
// arr[i] = arr[arr.Length - i - 1]; // теперь в  освободившейся arr[i] заносим последний элемент в массиве arr[arr.Length - i - 1] .
// arr[arr.Length - i - 1] = temp;  // у нас освободилось значение последнего элемента и в него мы сейчас переносим значение из temp .
// // по циклу for поочередно меняются все элементы.

// // Задача 55:___________________________________________________________________________________________________________________
// //Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// // В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// //ПРЕРВЙ ВАРИАНТ РЕШЕНИЯ=============================================================================================
// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 10, 50);
// PrintArray(array);
// Console.WriteLine();

// if(array.GetLength(0) == array.GetLength(1))
// {
//     int[,] arr1 = ChangeRowsToColumns(array);
//     PrintArray(arr1);
// }
// else Console.WriteLine($"Колличество строк -> {rows} не ровно колличеству солбцов -> {columns}");
// Console.WriteLine();

// int[,] ChangeRowsToColumns(int[,] arr)
// {
//     int[,] result = new int[arr.GetLength(0),arr.GetLength(1)];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             result[i,j] = arr[j,i];
//         }
//     }
//     return result;
// }
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// // Ответ: Введите колличество строк: 4                                  //Введите колличество строк: 4
// //        Введите колличество столбцов: 5                               //Введите колличество столбцов: 4
// //        30 18 33 27 39                                                //34 47 43 25
// // .      25 19 24 46 14                                                //30 36 33 34
// //        15 46 25 24 24                                                //18 25 41 43
// //        24 10 10 27 10                                                //37 49 18 36

// //        Колличество строк -> 4 не ровно колличеству солбцов -> 5      //34 30 18 37
// //                                                                      //47 36 25 49
// //                                                                      //43 33 41 18
// //                                                                      //25 34 43 36

// //ВТОРОЙ ВАРИАНТ РЕШЕНИЯ====================================================================================================
// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 10, 50);
// PrintArray(array);
// Console.WriteLine();

// if(array.GetLength(0) == array.GetLength(1))
// {
//     ChangeRowsToColumns(array);
// }
// else Console.WriteLine($"Колличество строк -> {rows} не ровно колличеству солбцов -> {columns}");

// void ChangeRowsToColumns(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[j,i]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


//================================================================================ДОМАШНЯЯ РАБОТА===============================================================================================================

// //Задача 59:____________________________________________________________________________________________________________________
// // Отсортировать нечетные столбцы массива по возрастанию. 
// //Вывести массив изначальный и массив с отсортированными нечетными столбцами

// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 10, 50);

// PrintArray(array);
// Console.WriteLine();
// SortingEvenColumns(array);
// PrintArray(array);

// void SortingEvenColumns(int[,] arr)
// {
//     for (int j = 1; j < arr.GetLength(1); j += 2)
//     {
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int k = 0; k < arr.GetLength(0); k++)
//             {
//                 if (arr[i, j] < arr[k, j])
//                 {
//                     int temp = arr[k, j];
//                     arr[k, j] = arr[i, j];
//                     arr[i, j] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// //Ответ: Введите колличество строк: 4
// //       Введите колличество столбцов: 4
// //       11 31 17 50 
// //       23 36 10 47 
// //       41 19 30 37 
// //       22 47 18 34 

// //       11 19 17 34 
// //       23 31 10 37 
// //       41 36 30 47 
// //       22 47 18 50 

// //Задача 54:_____________________________________________________________________________________________________________________
// //Задайте двумерный массив. 
// //Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 10, 50);

// PrintArray(array);
// Console.WriteLine();
// SortingEvenRows(array);
// PrintArray(array);

// void SortingEvenRows(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(1); k++)
//             {
//                 if (arr[i, k] < arr[i, j])
//                 {
//                     int temp = arr[i, j];
//                     arr[i, j] = arr[i, k];
//                     arr[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// // Ответ: Введите колличество строк: 5
// //        Введите колличество столбцов: 5
// //        37 34 26 22 50 
// //        13 10 41 35 36 
// //        38 30 36 47 37 
// //        30 33 27 50 47 
// //        24 17 19 42 29 

// //        50 37 34 26 22 
// //        41 36 35 13 10 
// //        47 38 37 36 30 
// //        50 47 33 30 27 
// //        42 29 24 19 17 

// // Задача 56:______________________________________________________________________________________________________________________
// // Задайте прямоугольный двумерный массив. 
// // Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 1, 10);

// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Строка с наименьшей суммой - {SumRows(array)}");

// int SumRows(int[,] arr)
// {
//     int minrow = 0;
//     int minsum = 0;
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         minsum += arr[0, i];
//     }
//     for (int i = 1; i < arr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum += arr[i, j];
//         }
//         if (minsum > sum)
//         {
//             minsum = sum;
//             minrow = i+1;
//         }
//     }
//     return minrow;
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// // Ответ: Введите колличество строк: 3
// //        Введите колличество столбцов: 4
// //        9 4 7 4 
// //        9 7 1 4 
// //        10 5 10 4 

// // Строка с наименьшей суммой - 2


// // Задача 58:__________________________________________________________________________________________________________________
// // Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите колличество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// if(columns != rows)
// {
//     Console.WriteLine("Число строк должно быть равным числу столбцов");
//     return;
// }

// int[,] arrayA = GetArray(rows, columns, -10, 10);
// int[,]arrayB = GetArray(rows, columns, -10, 10);

// PrintArray(arrayA);
// Console.WriteLine();
// PrintArray(arrayB);
// Console.WriteLine();
// PrintArray(SumMatrix(arrayA,arrayB));

// int[,] SumMatrix(int[,]array1, int[,]array2)
// {
//     int[,]array3 = new int[array1.GetLength(0),array2.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//        for (int j = 0; j < array2.GetLength(1); j++)
//        {
//             for (int k = 0; k < array1.GetLength(1); k++)
//             {
//                 array3[i,j] = array3[i,j] + array1[i,k] * array2[k,j];  //C[i,j] = a*C[i,j] + b*Sum(A[i,k]*B[k,j]) формула!!!
//             }
//        } 
//     }
//     return array3;
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }
// // Оивет: Введите колличество строк: 2
// //        Введите колличество столбцов: 2

// //         0  -7  
// //         -3  5  

// //        -7  -3  
// //        -4  8  

// //        28  -56  
// //         1  49  

// Задача 60.___________________________________________________________________________________________________________________
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Один из вариантов решения ========================================================================================
Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер глубины: ");
int depth = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,,] array = new int[rows, columns, depth];

GetArray(array);
PrintArray(array);

void PrintArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Console.Write($"{Array[i, j, k]}({k},{i},{j}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void GetArray(int[,,] arr)
{
    int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = temp[count];
                count++;
            }
        }
    }
}
// Ответ: Введите колличество строк: 2
//        Введите колличество столбцов: 2
//        Введите размер глубины: 2

//        67(0,0,0) 85(1,0,0) 
//        22(0,0,1) 51(1,0,1) 

//       74(0,1,0) 36(1,1,0) 
//       48(0,1,1) 53(1,1,1) 

// ЕЩЁ ВАРИАНТ РЕШЕНИЯ ==================================================================================================

Console.WriteLine();
Console.Write("Введите размеры массива, ЧЕРЕЗ ПРОБЕЛ: ");
string[] nums = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries); //StringSplitOptions.RemoveEmptyEntries позволяет считать цифры из строки ввода, исключив пробелы меду цыфрами.
int[,,] array1 = GetArray1(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 10, 99);
PrintArray1(array1);

int[,,] GetArray1(int[] sizes, int min, int max)
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] Array1, int elementRandom)
{
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        {
            for (int k = 0; k < Array1.GetLength(2); k++)
            {
                if (Array1[i, j, k] == elementRandom) return true;
            }
        }
    }
    return false;
}

void PrintArray1(int[,,] Array1)
{
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        {
            for (int k = 0; k < Array1.GetLength(2); k++)
            {
                Console.Write($"{Array1[i, j, k]}({k},{i},{j})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
// Ответ: Введите размеры массива, ЧЕРЕЗ ПРОБЕЛ: 4 4 4
//        30(0,0,0)  59(1,0,0)  55(2,0,0)  32(3,0,0)  
//        33(0,0,1)  52(1,0,1)  17(2,0,1)  23(3,0,1)  
//        60(0,0,2)  70(1,0,2)  65(2,0,2)  27(3,0,2)  
//        84(0,0,3)  43(1,0,3)  93(2,0,3)  63(3,0,3)  

//        53(0,1,0)  45(1,1,0)  77(2,1,0)  68(3,1,0)  
//        50(0,1,1)  37(1,1,1)  42(2,1,1)  29(3,1,1)  
//        14(0,1,2)  28(1,1,2)  47(2,1,2)  72(3,1,2)  
//        46(0,1,3)  21(1,1,3)  39(2,1,3)  85(3,1,3)  

//        26(0,2,0)  58(1,2,0)  73(2,2,0)  96(3,2,0)  
//        89(0,2,1)  88(1,2,1)  64(2,2,1)  98(3,2,1)  
//        90(0,2,2)  34(1,2,2)  36(2,2,2)  18(3,2,2)  
//        61(0,2,3)  49(1,2,3)  48(2,2,3)  11(3,2,3)  

//        41(0,3,0)  74(1,3,0)  15(2,3,0)  62(3,3,0)  
//        87(0,3,1)  12(1,3,1)  95(2,3,1)  13(3,3,1)  
//        20(0,3,2)  91(1,3,2)  57(2,3,2)  40(3,3,2)  
//        35(0,3,3)  79(1,3,3)  22(2,3,3)  54(3,3,3)  

