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

// Задача №65:
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N с помощью рекурсии.
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumebs(M, N));

string PrintNumebs(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumebs(start + 1, end));
}
// Ответ: Введите число M: 4
//        Введите число N: 8
//        4, 5, 6, 7, 8

