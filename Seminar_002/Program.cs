
// int namber = new Random().Next(10, 100);
// int nam1 = namber/10; // 72 ->

Console.WriteLine("----------Задача №10----------");
//// Напишите программу, которая на вход принимает трёхзначеное число
//// и на выходе показывает вторую цифру этого числа.

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