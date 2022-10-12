// //Задача 1 в классе:--------------------------------------------------------------
////Напишите программу, которая по введенному номеру четверти, показывает диапазон
////возможных координат точек в этой четверти (x и e).

// Console.WriteLine("Введите номер четверти от 1 до 4 : ");
// int number = int.Parse(Console.ReadLine()!);
// switch(number){
//     case 1:
//         Console.WriteLine("В четверти №1 x > 0 и y > 0");
//         break;
//     case 2:
//         Console.WriteLine("В четверти №2 x < 0 и y > 0");
//         break;
//     case 3:
//         Console.WriteLine("В четверти №3 x < 0 и y < 0");
//         break;
//     case 4:
//         Console.WriteLine("В четверти №4 x > 0 и y < 0");
//         break;
//     default:
//         Console.WriteLine("Вы ввели не существующую четверть.. ");
//         break;
// }



// //Задача 2 в классе:--------------------------------------------------------------
// //Напишите программу, которая на вход принимает координаты двух точек и находит 
// //растояние между ними в 2D пространстве(на плоскости).
// //A(3,6); B(2,1) -> 5,09
// //A(7,-5); B(1,-1) -> 7,21

// Console.Write("Введите координуту хa первой точки: ");
// int xa = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координуту хb второй точки: ");
// int ya = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координуту ya первой точки: ");
// int xb = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координуту yb второй точки: ");
// int yb = int.Parse(Console.ReadLine()!);
// double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
// Console.WriteLine($"Если точка A имеет координаты {xa},{xb}, а точка B {ya},{yb}, то растояние между ними на плоскости будет ровно {result:F3}");




// //Задача 3 в классе:--------------------------------------------------------------------------------------------------------------
// // Напишите программу, которая на вход принимает число N и выдает таблицу квадратов
// // чисел от 1 до N.

// Console.WriteLine("Введите число: ");
// int nam = int.Parse(Console.ReadLine()!);
// int count = 1;
// if(nam < 1)
// {
//     Console.WriteLine("Введите число < 1");
// }
// else
// {
// Console.Write($"Квадрат всех чисел от 1 до {nam} равны ");
//     while(count < nam){
//         Console.Write($"{Math.Pow(count, 2)}, ");
//         count++;
//     }
//     Console.WriteLine($"{Math.Pow(count, 2)} ");
// }

//---------------------------------------Задача 4 в классе---------------------------------------------------------------
// Нужно определить является ли шестизначенное число счастливым.
//(сумма первых трех цифр равна суммепоследних трех цифр)

// Console.WriteLine("Введите шестизначенное число: ");
// string number = Console.ReadLine()!;
// if((number.Length == 6))
// {
//     int a = Convert.ToInt32(number[0] + number[1] + number[2]);
//     int b = Convert.ToInt32(number[3] + number[4] + number[5]);
//     if(a == b)
//     {
//         Console.WriteLine($"Введеное число {number} считается счастливым\n сумма чисел {number[0]} {number[1]} {number[2]}\n равна сумме чисел {number[3]} {number[4]} {number[5]}");
//     }
//     else
//     {
//         Console.WriteLine("Число НЕ считается счастливым");
//     }
// }
// else
// {
//     if((number.Length < 6))
//     {
//         Console.WriteLine($"Вы ввели число {number}, в нем меньше шести  цифр.");
//     }
//     if((number.Length > 6))
//     {
//         Console.WriteLine($"Вы ввели число {number}, в нем больше шести  цифр.");
//     }
// }





 
//---------------------------------------Домашняя работа-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом. (можно решить через строку, а можно математически)
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Задача №19 :  ");
Console.WriteLine("Введите пятизначное число: ");
string nam = Console.ReadLine()!;
if(nam.Length == 5)
{
    if(nam[0] == nam[4] && nam[2] == nam[3])
        Console.WriteLine($"Число {nam} является полиндромом!");
    else
    {
        Console.WriteLine($"Число {nam} НЕ является полиндромом!");
    }
}
else
{
    if(nam.Length < 5)
    {
        Console.WriteLine($"В числе {nam} меньше пяти цифр");
    }
    if(nam.Length > 5)
    {
        Console.WriteLine($"В числе {nam} больше пяти цифр");
    }
}

// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Задача № 21 : ");
Console.Write("Введите координуту хa первой точки: ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координуту ya второй точки: ");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координуту za третей точки: ");
int za = int.Parse(Console.ReadLine()!);
Console.Write("Введите координуту xb первой точки: ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координуту yb второй точки: ");
int yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координуту zb третей точки: ");
int zb = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)+ Math.Pow(zb - za, 2));
Console.WriteLine($"Если точка A имеет координаты {xa},{xb},{za} а точка B {ya},{yb},{zb} то растояние между ними в 3D плоскости будет ровно {result:F2}");

// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число от 1 до... :");
int number = int.Parse(Console.ReadLine()!);
int count =1;
if(number < 1)
{
    Console.WriteLine("Вы ввели цифру < 1");
}
else
{
    Console.Write($"Куб всех чисел от 1 до {number} равны ");
    while(count < number)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count++;
    }
    Console.WriteLine($"{Math.Pow(count, 3)} ");
}