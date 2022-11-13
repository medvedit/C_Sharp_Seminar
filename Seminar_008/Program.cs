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
//ПРЕРВЙ ВАРИАНТ РЕШЕНИЯ==================================================
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

//ВТОРОЙ ВАРИАЕТ РЕШЕНИЯ==========================================
Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 10, 50);
PrintArray(array);
Console.WriteLine();

if(array.GetLength(0) == array.GetLength(1))
{
    ChangeRowsToColumns(array);
}
else Console.WriteLine($"Колличество строк -> {rows} не ровно колличеству солбцов -> {columns}");

void ChangeRowsToColumns(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[j,i]}  ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
