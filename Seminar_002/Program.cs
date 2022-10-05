
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
    int num1 = num%100/10;
    Console.WriteLine($"Вторая цифра введенного Вами числа {num} равна {num1}");
}

Console.WriteLine("----------Задача №13----------");
////Напишите задачу, которая выводит третью цифру заданного числа или сообщяет, 
//// что третьей цифры нет. (Максимальгое число 100.000).

int number = new Random().Next(1, 100001);
if(number < 100)
{
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"В цисле {number} третья цифра отсутствует.");
}
if((number >= 100) && (number < 1000))
{
    int number1 = number%10;
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"Третья цыфра числа {number} равна {number1}");
}
if((number >= 1000) && (number < 10000))
{
    int number1 = number%100/10;
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"Третья цыфра числа {number} равна {number1}");
}
if((number >= 10000) && (number < 100000))
{
    int number1 = number%1000/100;
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"Третья цыфра числа {number} равна {number1}");
}
if((number >= 100000) && (number < 100001))
{
    int number1 = number%10000/1000;
    Console.WriteLine($"Случайное число {number}");
    Console.WriteLine($"Третья цыфра числа {number} равна {number1}");
}
