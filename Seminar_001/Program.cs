// Однострочный комментарий 

/* Многострочный комментарий. Можно 
закомментировать
несколько строк 
кода или текста*/

//ALT+Shift+F - Выравниватет написанный код.

// Быстро закомментировать можно 
// сочетанием клавиш "cmd + /" , предварительно 
// выделив нужный код или текст

// Задача 1
// Напишите программу, которая на вход принимает два чиста и проверяет,
//является ли первое число квадратом второго.
/*Console.WriteLine("Введите первое число: ");
int Nam1 = int.Parse(Console.ReadLine()!); // добавил !

Console.WriteLine("Введите второе число: ");
int Nam2 = int.Parse(Console.ReadLine()!); //int.Parse - конвертирование строки в тип int

if (Math.Pow(Nam2, 2) == Nam1)//Math - библиотека позволяющяя работать с различными  математическими методами. Pow - степень
{
    Console.WriteLine("Первое число является квадратом второго!");

}
else
{
    Console.WriteLine("Первое число не является квадратом второго!");
}
*/

//Задача 2
// Напишите программу, которая на вход принимает число и выдает его квадрат.
// Console.WriteLine("Введите число: ");
// int Nam = int.Parse(Console.ReadLine()!);
// int Degree = Convert.ToInt32(Math.Pow(Nam, 2));//Convert.ToInt32 преобразует Math.Pow из double в int
// //int Degree = Nam * Nam; // Можно строка 39 или 38
// Console.Write("Квадратом Вашего числа будет число: ");
// Console.WriteLine(Degree);

//Задача 3 Программа на входе полкчает номер дня недели, а на выходе выводит название этого дня недели.
// Console.WriteLine("Введите нмер дня надели: ");
// int Nam = int.Parse(Console.ReadLine()!);
// if (Nam == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if (Nam == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if (Nam == 3)
// {
//     Console.WriteLine("Среда");
// }
// if (Nam == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if (Nam == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if (Nam == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if (Nam == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// if (Nam <= 0)
// {
//     Console.WriteLine("День недели может быть в диапазоне от 1 до 7. Введите верный номер дня недели.");
// }
// if (Nam >= 8)
// {  

//     Console.WriteLine("День недели может быть в диапазоне от 1 до 7. Введите верный номер дня недели.");
// }
// // Можно сократить if (DayNum < 1 || DayNum > 7) 
// // Что бы не далать проверку через if , можно использовать switch () case, например:
// switch (Nam)
// {
//     case 1: Console.WriteLine("Понедельник");
//             break;
//     case 2: Console.WriteLine("Вторник");
//             break;
//     case 3: Console.WriteLine("Среда");
//             break;
//     case 4: Console.WriteLine("Четверг");
//             break;
//     case 5: Console.WriteLine("Пятница");
//             break;
//     case 6: Console.WriteLine("Суббота");
//             break;
//     case 7: Console.WriteLine("Воскресенье");
//             break;
//     default: Console.WriteLine("В неделе всего 7 дней )))");
//             break;                                        
// }

// Задача 4
// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
// Console.WriteLine("Введите число: ");
// int Nam = int.Parse(Console.ReadLine()!);
// int count = -Nam;
// if (Nam > 0)
// {
//     count = Nam - Nam - Nam;
// }
// else
// {
//     Nam = count;
//     count = Nam - Nam - Nam;
// }
// Console.Write("\"");
// while (count < Nam)
// {
//     Console.Write($"{count}, ");
//     count++;
// }
// Console.Write(count);
// Console.WriteLine("\"");

                                                                    // Домашняя работа

//if (Nam%2=0)

//Задача 2:
//Напишите программу, которая на вход принимет два числа и выдает, Какое число больше, а какое меньше.
            // Console.WriteLine("Введите первое число: ");
            // int nam1 = int.Parse(Console.ReadLine()!);
            // Console.WriteLine("Введите второе число: ");
            // int nam2 = int.Parse(Console.ReadLine()!);
            // if (nam1 > nam2){
            //     Console.WriteLine($"{nam1} больше чила {nam2}");
            // }
            // else{
            //     Console.WriteLine($"{nam2} больше числа {nam1}");
            // }
//Задача 4:
//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
            // Console.WriteLine("Введите первое число: ");
            // int nam1 = int.Parse(Console.ReadLine()!);
            // Console.WriteLine("Введите второе число: ");
            // int nam2 = int.Parse(Console.ReadLine()!);
            // Console.WriteLine("Введите третье число: ");
            // int nam3 = int.Parse(Console.ReadLine()!);

            // int max = 0;
            // if(nam1>nam2){
            //     max=nam1;
            // }
            // else{
            //     max=nam2;
            // }
            // if(nam1<nam3){
            //     max=nam3;
            // }
            // Console.WriteLine($"{max} максимальное из трех чсел");
// Задача 6:
//Напишите программу,которая на вход принимает число и выдает, является ил число чётным.
            // Console.WriteLine("Введите число: ");
            // int nam = int.Parse(Console.ReadLine()!);
            // if(nam%2==0){
            //     Console.WriteLine($"{nam} является ЧЁТНЫМ числом");
            // }
            // else{
            //     Console.WriteLine($"{nam} являеьтя НЕ ЧЁТНЫМ числом");
            // }          