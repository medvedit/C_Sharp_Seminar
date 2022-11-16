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

// Задача 69:____________________________________________________________________________________
// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A = {A}; B = {B} -> {DegreeNumber(A, B)}");

int DegreeNumber(int a, int b)
{
    if (b == 1) return a;
    return a * DegreeNumber(a, b - 1);
}
// Ответ: Введите число A: 2
//        Введите число B: 3
//        A = 2; B = 3 -> 8

