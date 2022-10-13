//Работа в классе------------------------------------------------------------------------------------------------------------------------------------------

//Задача №1 в классе--------------------------------------

// Напишите программу, которая на вход принимает число (А)
//и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма всех чисел от 1 до {A} = {GetSum(A)}");

// int GetSum (int limit)
// {
//     int sum = 0;
//     for (int i = 1; i <= limit; i++)
//     {
//        sum = sum + i; 
//     }
//     return sum;
// }

// Задача №2 в классе---------------------------------

// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

// ПЕРВОЕ РЕШЕНИЕ !!!-------------------------------------------------------------------
// Console.WriteLine("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {A} состоит из {NumberDigit(A)} цифр");

// int NumberDigit (int limit)
// {
//     char[] c = limit.ToString().ToCharArray(); // перевел из строки в массив
//     int a = 0;
//     for (int i = 0; i <= c.Length; i++)
//     {
//         a = i;
//     }
//     return a;
// }

// ВТОРОЕ РЕШЕНИЕ !!!------------------------------------------------------------------
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Колличество цыфр в числе {number} = {CountNumber(number)}");

// int CountNumber(int nam)
// {
//     int count = 0;
//     do
//     {
//       nam /=10;
//       count++;  
//     } 
//     while (nam > 0);
//     return count;
// }


// ТРЕТИЕ РЕШЕНИЕ !!!------------------------------------------------------------------
//Console.WriteLine("введите число:");
//Console.WriteLine($"чисел: {Console.ReadLine()!.Length}");


// Задача №3 в классе-----------------------------------
//Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

// Console.WriteLine("Введите число: ");
// int F = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Произведение всех чисел в числе {F} = {GetMultiply(F)} ");

// int GetMultiply (int limit)
// {
//     int x = 1;
//     for (int i = 1; i <= limit; i++)
//     {
//       x = x * i;  
//     }
//     return x;
// }


// Задача №4 в классе----------------------------------------
//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

// ПЕРВОЕ РЕШЕНИЕ !!!-------------------------------------------------------------------
// int[] Arrey = new int [8];
// FillArray(Arrey.Length);
// Console.WriteLine($"[{String.Join(",", Arrey)}]");

// void FillArray(int size){
//     for (int i = 0; i < size; i++)
//     {
//         Arrey[i] = new Random().Next(0,2);
//     }
// }

// ВТОРОЕ РЕШЕНИЕ !!!------------------------------------------------------------------
// int[] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//        result[i] = new Random().Next(0,2); 
//     } 
//     return result;
// }



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

// GetDegree(a,b);

// void GetDegree(int x, int y)
// {
//     int result = Convert.ToInt32(Math.Pow(x, y));
//     Console.WriteLine($"число {x} в степени {y} = {result}");
// } 




//ВТОРОЕ РЕШЕНИЕ !!! --------------------------------------------
// Console.WriteLine("Введите число а: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число b: ");
// int b = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"число {a} в степени {b} = {GetDegree(a,b)}");


// int GetDegree (int x, int y)
// {
//     int result = Convert.ToInt32(Math.Pow(x, y));
//     return result;
// }

// Задача 27:--------------------------
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {A} равна {NumberSum(A)}");

int NumberSum (int number)
{
    int result = 0;

    for (int i = 0; i < number; i++)
    {
    result = result + number % 10;
    number = number / 10;
    }
    
    return result;
}







// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]