// //Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 10, 50);
PrintArray(array);
Console.WriteLine();
ArrayTurn(array);
PrintArray(array);


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
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }

}

void ArrayTurn(int[,] Arr)
{
    for (int j = 0; j < Arr.GetLength(1); j++)
    {
        int temp = Arr[0, j];
        Arr[0, j] = Arr[Arr.GetLength(0) - 1, j];
        Arr[Arr.GetLength(0) - 1, j] = temp;
    }
}
//Ответ: Введите колличество строк: 4
//       Введите колличество столбцов: 4
//       40 20 24 14 
//       21 39 29 45 
//       20 11 30 34 
//       33 26 18 22 

//       33 26 18 22 
//       21 39 29 45 
//       20 11 30 34 
//       40 20 24 14 

// int temp = arr[i];  // обьявляем временную переменную temp и зпносим в нее значение arr[i], а вначале цикла for это = int i = 0 .
// arr[i] = arr[arr.Length - i - 1]; // теперь в  освободившейся arr[i] заносим последний элемент в массиве arr[arr.Length - i - 1] .
// arr[arr.Length - i - 1] = temp;  // у нас освободилось значение последнего элемента и в него мы сейчас переносим значение из temp .
// // по циклу for поочередно меняются все элементы.

