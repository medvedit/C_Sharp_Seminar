//Работа в классе------------------------------------------------------------------------------------------------------------------------------------------

//Задача №1 в классе.

// Напишите программу, которая на вход принимает число (А)
//и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех чисел от 1 до {A} = {GetSum(A)}");

int GetSum (int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
       sum = sum + i; 
    }
    return sum;
}




// ---------------------------------------------------------------Домашняя работа-------------------------------------------------------------
// Задача 25:-----------
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// ПЕРВОЕ РЕШЕНИЕ !!!  ------------------------------------------
// Console.WriteLine("Введите число а: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число b: ");
// int b = int.Parse(Console.ReadLine()!);
// void GetDegree(int a, int b)
// {
//     int result = Convert.ToInt32(Math.Pow(a, b));
//     Console.WriteLine($"число {a} в степени {b} = {result}");
// }    
// GetDegree(a,b);


// ВТОРОЕ РЕШЕНИЕ !!! --------------------------------------------
// Console.WriteLine("Введите число а: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число b: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"число {a} в степени {b} = {GetDegree(a,b)}");
// int GetDegree (int a, int b)
// {
//     int result = Convert.ToInt32(Math.Pow(a, b));
//     return result;
// }