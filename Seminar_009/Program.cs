// // Задание №1:___________________________________________________________________________
// // Разбор работы рекурсии на основе вычесления факториала.
// // n = 1*2*3*4
// int f = 4;
// Console.WriteLine(Factorial(f));
// int Factorial(int n)
// {
//     if (n == 1) return 1; // как только n == 1 , программа остановит выполнение, выход.
//     return n * Factorial(n - 1); //n * Factorial(3), т.е. на выходе 4 * 3 * 2 * 1
// }
// // Ответ: 24

// // Задача №2________________________________________________________________________________
// // С помощью рекурсии выведите в консоль числа от 1 до N.
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumebs(1, N));

// string PrintNumebs(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumebs(start + 1, end));
// }
// // Ответ: Введите число N: 5
// //        1, 2, 3, 4, 5

// // Задача №65:_________________________________________________________________________________
// // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N с помощью рекурсии.
// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumebs(M, N));

// string PrintNumebs(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumebs(start + 1, end));
// }
// // Ответ: Введите число M: 4
// //        Введите число N: 8
// //        4, 5, 6, 7, 8


// // Задача 67:____________________________________________________________________________________
// // Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(SumNumber(N));

// int SumNumber(int n)
// {
//     if (n < 1)
//     {
//         return n;
//     }
//     return n % 10 + SumNumber(n / 10);
// }
// Ответ: Введите число N: 4512
//        12

// // Задача 69:____________________________________________________________________________________
// // Напишите программу, которая на вход принимает два числа A и B, 
// // и возводит число А в целую степень B с помощью рекурсии.

// Console.Write("Введите число A: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int B = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"A = {A}; B = {B} -> {DegreeNumber(A, B)}");

// int DegreeNumber(int a, int b)
// {
//     if (b == 0) return 1;
//     if (b == 1) return a;
//     return a * DegreeNumber(a, b - 1);
// }
// // Ответ: Введите число A: 2
// //        Введите число B: 3
// //        A = 2; B = 3 -> 8

// // =================================================================  Домашняя работа  ============================================================================
// // Задача 64:________________________________________________________________________
// // Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// // Выполнить с помощью рекурсии.

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"N = {N} -> \"{PrintNumebs(N, 1)}\"");

// string PrintNumebs(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumebs(start - 1, end));
// }
// // Ответ: Введите число N: 7
// //        N = 7 -> "7, 6, 5, 4, 3, 2, 1"


// // Задача 66:________________________________________________________________________
// // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// int sum = 0;

// Console.WriteLine($"M = {M}; N = {N} -> {SumOfElements(M, N, sum)}");

// int SumOfElements(int m, int n, int count)
// {
//     if (m == n) return m;
//     return count += (m++) + SumOfElements(m, n, count);
// }
// // Ответ: Введите число M: 1
// //        Введите число N: 15
// //        M = 1; N = 15 -> 120



// Задача 68:__________________________________________________________________________
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"M = {M}, N={N} -> A({M},{N}) = {AckermanFunction(M,N)} ");

int AckermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  if (n == 0) return AckermanFunction(m - 1, 1);
  return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

// Ответ: Введите число M: 3
//        Введите число N: 2
//        M = 3, N=2 -> A(3,2) = 29