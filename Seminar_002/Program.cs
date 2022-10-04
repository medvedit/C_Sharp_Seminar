
// int namber = new Random().Next(10, 100);
// int nam1 = namber/10; // 72 ->

Console.WriteLine("----------Задача №10----------");
// Напишите программу, которая на вход принимает трёхзначеное число
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхначеное число: ");
int number = int.Parse(Console.ReadLine()!);
if((number < 100) || (number >= 1000))
{
     Console.WriteLine($"Число {number} не является трёхзначеным!");
}
if((number >= 100) && (number < 1000))
{
    int number1 = number%100/10;
    Console.WriteLine($"Вторая цифра введенного Вами числа {number} равна {number1}");
}
