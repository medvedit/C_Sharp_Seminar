﻿// //Задача1 в классе.-------------------------
// // напишите программу, которая выводит случайное число из отрезка [10,.. 99]
// // и выводит наибольшее число.
// int namber = new Random().Next(10, 100); //Если в .Next(100) указать одно число, будет вывод в диапазоне от 0 до 99. Можно указать число .Next(-10,-1)
// // 72 -> 7
// Console.WriteLine(namber);
// int nam1 = namber / 10; //72 => 7,2 => 7
// int nam2 = namber % 10; // 72 => 7,2 => 2
// if(nam1 > nam2)                      //int Max = nam1;
// {                                    //if(nam2 > nam1)
//     Console.WriteLine(nam1);         //{
// }                                    //Max = nam2;
// if(nam1 < nam2)                      //}
// {                                    //Console.WriteLine($"Максимальная цифра в числе {namber} равна {Max}");
//     Console.WriteLine(nam2);
// }

// //Задача2 в классе.--------------------------------
// // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// // 456 -> 46
// // 782 -> 72
// // 918 -> 98
// int number = new Random().Next(100, 1000);
// int number1 = number/100*10;
// int number2 = number%100/10;
// int number3 = number%10;
// Console.WriteLine(number);
// Console.WriteLine($"Получилось число{number1 + number3}, а цифру {number2} исключили.");

// //Задача3 в классе.--------------------------------
// //Напишите программу, которая будет принимать на вход два числа и выводить, 
// //является ли второе число кратным первому. Если второе число не кратно числу первому, 
// //то программа выводит остаток от деления.
// //34, 5 -> не кратно, остаток 4
// //16, 4  -> кратно
// Console.WriteLine("Введите первое число: ");
// int Nam1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int Nam2 = int.Parse(Console.ReadLine()!);
// int Namber = Nam1 % Nam2;
// if(Namber == 0)
// {
//     Console.WriteLine($"Число {Nam2} является кратным чеслу {Nam1}. Остаток равен {Namber}");
// }
// else
// {
//     Console.WriteLine($"Число {Nam2} не является кратным чеслу {Nam1}. Остаток равен {Namber}");
// }

// // Задача 4 в классе.----------------------------------
// // Напишите программу, которая принимает на вход число и проверяет, 
// // кратно ли оно одновременно 7 и 23.
// // 14  ->  нет
// // 46  ->  нет
// // 161 ->  да
// Console.WriteLine("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// int y = 7;
// int z =23;
// if((x % y == 0) && (x % z == 0))
// {
//     Console.WriteLine($"Число {x} является одновременно кратным для числа {y} и {z}");
// }
// else
// {
//     Console.WriteLine($"Число {x} не является одновременно кратным для числа {y} и {z}");
// }

// //Задача 5 в классе.--------------------------------------
// //Напишите программу, которая принимает на вход два числа и проверяет, 
// //является ли одно число квадратом другого.
// Console.WriteLine("Введите первое число: ");
// int square1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите первое число: ");
// int square2 = int.Parse(Console.ReadLine()!);
// if(square1 > square2){
//     if(square1 == Math.Pow(square2,2)){
//     Console.WriteLine($"Число {square1} является квадратом числа {square2}");
//     }else{
//       Console.WriteLine($"Число {square1}  не является квадратом числа {square2}");  
//     }
// }  else if (square1 < square2){
//     if(square2 == Math.Pow(square1,2)){
//     Console.WriteLine($"Число {square2} является квадратом числа {square1}");
//     }else{
//       Console.WriteLine($"Число {square2}  не является квадратом числа {square1}");  
//     }
// }    





//_________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
Console.WriteLine("----------Задача №10----------");
// Напишите программу, которая на вход принимает трёхзначеное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхначеное число: ");
int num = int.Parse(Console.ReadLine()!);
if((num < 100) || (num >= 1000))
{
     Console.WriteLine($"Число {num} не является трёхзначеным!");
}
if((num >= 100) && (num < 1000))
{
    int num1 = num % 100 / 10;
    Console.WriteLine($"Вторая цифра введенного Вами числа {num} равна {num1}");
}

Console.WriteLine("----------Задача №13----------");
////Напишите задачу, которая выводит третью цифру заданного числа или сообщяет, 
//// что третьей цифры нет. (Максимальгое число 100.000).

int number = new Random().Next(1, 100001);
if(number < 100)
{
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"В числе {number} третья цифра отсутствует.");
}
if((number >= 100) && (number < 1000))
{
    int number1 = number % 10;
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"Третья цыфра числа {number} равна {number1}");
}
if((number >= 1000) && (number < 10000))
{
    int number1 = number % 100 / 10;
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"Третья цыфра числа {number} равна {number1}");
}
if((number >= 10000) && (number < 100000))
{
    int number1 = number % 1000 / 100;
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"Третья цыфра числа {number} равна {number1}");
}
if((number >= 100000) && (number < 100001))
{
    int number1 = number % 10000 / 1000;
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"Третья цыфра числа {number} равна {number1}");
}

Console.WriteLine("----------Задача №15----------");
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным. 
// Обязательно сделать проверку на ввод чисел меньше 1 и больше 7.

Console.Write("Введите номер дня недели: ");
int dayweek = int.Parse(Console.ReadLine()!);
if((dayweek < 1) || (dayweek > 7))
{
    Console.WriteLine($"Введённое Вами число {dayweek} не является номером дня недели. В неделе семь дней. ");
    
} 
if((dayweek >= 1) && (dayweek <= 5))
{
    Console.WriteLine($"Введённый Вами день недели является рабочим днём.");

}
if((dayweek >= 6) && (dayweek <= 7))
{
    Console.WriteLine($"Введённый Вами день недели является выходным днем днём. GO!!! писать код)))))");
}