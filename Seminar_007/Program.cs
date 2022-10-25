// Задача №1 в классе:__________________________________________________________
// Задайте двумерный массив размера m на n, и заполните его случайными целыми числами.

 Console.WriteLine("Введите колличество строк: ");
 int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите колличество столбцов: ");
 int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 50);
PrintArray(array);

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

// Задача 48: 
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

