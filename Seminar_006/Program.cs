// Задача 1 в классе_________________________________________________
// Напишите программу, которая перевернет одномерный массив.
// Первый вариант решения_____________________________________________
// int[] myArray = GitArray(10,0,10);
// Console.WriteLine($"[{String.Join(", ", myArray)}]");

// ReversalArray(myArray);
// Console.WriteLine($"[{String.Join(", ", myArray)}]");

// void ReversalArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)  // В этом случае делим массив пополам!
//     {
//         int temp = arr[i];  // обьявляем временную переменную temp и зпносим в нее значение arr[i], а вначале цикла for это = int i = 0 .
//         arr[i] = arr[arr.Length - i - 1]; // теперь в  освободившейся arr[i] заносим последний элемент в массиве arr[arr.Length - i - 1] .
//         arr[arr.Length - i - 1] = temp;  // у нас освободилось значение последнего элемента и в него мы сейчас переносим значение из temp .
//         // по циклу for поочередно меняются все элементы.
//     }
// }

//Второй вариант решения___________________________________________________

// int[] myArray = GitArray(10,0,10);
// Console.WriteLine($"[{String.Join(", ", myArray)}]");

// int[] myArray2 = ReversalArray2(myArray);  // инициализировали новый массив и занесли в него result из метода ReversalArray2 .
// Console.WriteLine($"[{String.Join(", ", myArray2)}]");  // Вывели полученный массив.

// int[] ReversalArray2(int[] arr2)
// {
//     int[] result = new int[arr2.Length];  // создаем новый массив int[] result на основании входящего массива с той де длинной [arr2.Length] .
//     for (int i = 0; i < arr2.Length; i++)
//     {
//         result[i] = arr2[arr2.Length - i - 1]; // переносим все элементы с конца массива в начало.
//     }
//     return result;  // результат сохранили.
// }
//============================================================================МЕТОД=============
int[] GitArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
//==============================================================================================

//Задача 2 в классе________________________________________________________________________

// Нужно написать программу, которая на вход принимает три числа и проверяет 
//может ли существовать треугольник такой длинны.  
// справедливы 
// неравенства:       AB < AC + CB,  AC < AB + BC,  BC < BA + AC

// Вариант первый-----------------------------------------------------------------------
// Console.Write("Введите первое чило \"A\": ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите первое чило \"B\": ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите первое чило \"C\": ");
// int c = int.Parse(Console.ReadLine()!);

// if(a < c + b && c < a + b && b < a + c) {Console.WriteLine("ДА");}
// else {Console.WriteLine("НЕТ");}

//Вариант второй-------------------------------------------------------------------------

// Console.WriteLine("Введите три числа: ");
// int a = int.Parse(Console.ReadLine()!);
// int b = int.Parse(Console.ReadLine()!);
// int c = int.Parse(Console.ReadLine()!);

// if(CheckExistsTriangle(a, b, c)) {Console.WriteLine("Может существовать");}
// else {Console.WriteLine("Не может существовать");}

// bool CheckExistsTriangle(int a, int b, int c)  // метод Boolean (Логический)
//     {
//         return a < b + c && b < a + c && c < a + b;
//     }   

//Задача 3 в классе________________________________________________________________________

//Написать программу, которая будет преобразовывать десятичное число в двоичное.

// Вариант первый-----------------------------------------------------------------------

// Console.Write("Введите число для перевода в двоичную систему : ");
// int transfer = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Convert.ToString(transfer, 2));   // Convert.ToString перевод в другую систему, меняем цифру в конце.

//Вариант второй-------------------------------------------------------------------------


// Console.Write("Введите число для перевода в двоичную систему : ");
// int transfer = int.Parse(Console.ReadLine()!);

// Console.WriteLine(ConvertToBinary(transfer));

// String ConvertToBinary(int pass)
// {
//     int temp;
//     String binary = "";
//     String finalBinary = "";
//     do
//     {
//         temp = pass % 2;
//         binary = binary + temp;  // binary += temp
//         pass = pass / 2;  // transfer /= 2
//     } while (pass >= 1);
//     for (int i = binary.Length - 1; i >= 0; i--)
//     {
//         finalBinary = finalBinary + binary[i];
//     }
//     return finalBinary;
// }
// Ответ : Введите число для перевода в двоичную систему : 45
//         101101

//Задача 4 в классе________________________________________________________________________

//Написать программу, которая будет создавать копию заданного массива 
//с помощь поэлементного копирования.

// int[] myArray = GitArray(10,0,10);
// Console.WriteLine($"[{String.Join(" , ", myArray)}]");

// int[] myArrayCopy = CopyArray(myArray);
// Console.WriteLine($"[{String.Join(" | ", myArrayCopy)}]");

// int[] CopyArray(int[] arr)
// {
//     int[] result = new int[arr.Length];  
//     for (int i = 0; i < arr.Length; i++)
//     {
//         result[i] = arr[i]; 
//     }
//     return result;  
// }
// Ответ : [5 , 2 , 7 , 6 , 3 , 7 , 0 , 3 , 8 , 1]
//        [5 | 2 | 7 | 6 | 3 | 7 | 0 | 3 | 8 | 1]


//=============================================================== ДОМАШНЯЯ РАБОТА ======================================================================================

// Задача 41: ---------------------------------------------

// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4



Console.Write("Введите некоторое колличество положительных и отрицательных чисел\n(ЧЕРЕЗ ПРОБЕЛ, ПОСЛЕ ПОСЛЕДНЕЙ ЦИФРЫ ПРОБЕЛ НЕ ВВОДИТЬ!!!)\n: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);


Console.WriteLine($"  {String.Join(", ", array)}     цифр > 0 -> {PositiveNumbers(array)}");


int PositiveNumbers(int[] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if(collection[i] > 0) count++;
    }
    return count;
}
//  ОТВЕТ : Введите некоторое колличество положительных и отрицательных чисел
//        (ЧЕРЕЗ ПРОБЕЛ, ПОСЛЕ ПОСЛЕДНЕЙ ЦИФРЫ ПРОБЕЛ НЕ ВВОДИТЬ!!!)
//        : 1 34 -29 -1 0 -992
//        1, 34, -29, -1, 0, -992     цифр > 0 -> 2


// Задача 43: ---------------------------------------------
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double k2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($" b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {GitSum(b1,k1,b2,k2)}");


(double, double) GitSum(double b1, double k1, double b2, double k2)
{
    double y = 0;
    double x = 0;
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
     var tuple = (x, y);
    return tuple;
}
// Ответ: Введите значение b1: 2
//        Введите значение k1: 5
//        Введите значение b2: 4
//        Введите значение k2: 9

//        b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5, -0,5)

// Доп задача: ------------------------------------------------------------------------
//Найти произведение всех элементов массива целых чисел, 
//меньших заданного числа. Размерность массива –10. 
//Заполнение массива осуществить случайными числами от 50 до 100.

int[] myArray = GitArray(10,50,101);
Console.Write("Введите число ограничения от 50 до 100:  ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Произведение всех чисел в массиве -> [{String.Join(" , ", myArray)}]\n до числа {n} ==-> {MultiplyNumber(myArray, n)}");

long MultiplyNumber(int[]array, int x)
{
    long sum = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < x) sum *= array[i];
    }
    return sum;
}

// Ответ:  Введите число ограничения от 50 до 100:  85
//         Произведение всех чисел в массиве -> [64 , 61 , 85 , 94 , 71 , 64 , 86 , 77 , 86 , 84]
//         до числа 85 ==-> 114740871168