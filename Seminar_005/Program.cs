// // Задача №1 в классе------------------------------------------------------------------------------------------------------------------
// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
// // Найдите сумму отрицательных и пложительных элементов.

// //Метод создания массива  по параметрам______________________________________________________________________
// int[] GitArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// //________________________________________________________________________________________________________
// //Вызов метода создания массива_____________________________________________________________________________________
// int[] array = GitArray(12, -9, 9);
// Console.WriteLine(String.Join("  ", array));
// //________________________________________________________________________________________________________
// //Складываем положительные и отрицательные цифры__________________________________________________________
// int negativeSum = 0;  // создаем переменные в еоторых будем суммировать
// int positiveSum = 0;  // отрицательные и положительные числа.

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] < 0)
//     {
//         negativeSum += array[i];
//     }
//     else
//     {
//         positiveSum += array[i];
//     }
// }
// Console.WriteLine($"Positive Sum =  {positiveSum}\nNegative Sum = {negativeSum}");
// //______________________________________________________________________________________________________


// Задача 2 в классе:--------------------------------------------------------------------------------------------------------------------
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] arr = GitArray(12, -92, 93);
// Console.WriteLine(String.Join("   ", arr));


//Вариант 1_______________________________________________________________
//     for (int i = 0; i < arr.Length; i++)
//     {
//        arr[i] = arr[i] *= -1;
//     }
// Console.WriteLine(String.Join("   ", arr));
//________________________________________________________________________

////Вариант 2_______________________________________________________________
// void ExchangeArray( int [] arr1)
// {
//     for (int i = 0; i < arr1.Length; i++)
//     {
//         arr1[i] *= -1;
//     }
//      Console.WriteLine(String.Join("   ", arr1));
// }
// ExchangeArray(arr);
////________________________________________________________________________

// //Вариант 3_______________________________________________________________
// int[] ExchangeArr(int[] rez)
// {   
//     for (int i = 0; i < rez.Length; i++)
//     {
//         rez[i] = rez[i] * -1;
//     }
//     return rez;
// }    
// Console.WriteLine(String.Join("   ", ExchangeArr(arr)));
// //________________________________________________________________________


// Задача 3 в клсаасе:-------------------------------------------------------------------------------------------------------------
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] arra = GitArray(12, -5, 5);
// Console.WriteLine($"Случайный массив -> {String.Join("   ", arra)}");

// int A = new Random().Next(-5, 5);
// Console.WriteLine($"Случайное, искомое число -> {A}");

// NumberSearch(arra);



// void NumberSearch(int[]arra1)
// {
//     int count = 0;
//     for (int i = 0; i < arra1.Length; i++)
//     {
//         if(arra1[i] == A)
//         {   
//             count++;
//         }
//     }
//     if(count == 0)
//     {
//         Console.WriteLine($"В массиве [{String.Join(", ", arra1)}]-> встретилось {count} раз(а) -> нет");
//     }
//     else
//     {
//         Console.WriteLine($"В массиве [{String.Join(", ", arra1)}] -> встретилось {count} раз(а) -> да");
//     }
// }


// Задача 4 В классе:----------------------------------------------------------------------------------------------------------------------------------------
// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int[] massiv = GitArray(123, 0, 9999);
// Console.WriteLine($"Случайный массив -> {String.Join("   ", massiv)}");

// NumberSearch(massiv);


// void NumberSearch(int[] numberarray)
// {
//     int count = 0;
//     for (int i = 0; i < numberarray.Length; i++)
//     {
//         if(numberarray[i] >= 10 && numberarray[i] <= 99)
//         {
//             count++;
//         }
//     }
//     if(count == 0)
//     {
//         Console.WriteLine($"В этом массиве, числа в промежутке от 10 до 99 встречаются {count} раз");
//     }
//     else
//     {
//         Console.WriteLine($"В этом массиве, числа в промежутке от 10 до 99 встречаются {count} раз");
//     }
// }

// Задача 5:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


// // Решение через void-----------------------------------------------------------------------------------
// int[] massiv1 = GitArray(7, 0, 9);
// Console.WriteLine($"Первый массив -> [ {String.Join("  ", massiv1)} ]");

// ResultArray(massiv1);

// void ResultArray(int[] arraymetod)
// {
//     Console.Write($"Произведение пар чисел в массиве -> [ ");
//     for (int i = 0, j = arraymetod.Length - 1; i < arraymetod.Length / 2; i++, j--)
//     {
//         Console.Write(arraymetod[i] * arraymetod[j] + " ");
//     }
//     if(arraymetod.Length % 2 != 0)
//     {
//         Console.WriteLine($"{arraymetod[arraymetod.Length/2]} ]");
//     }
//     else
//     {
//         Console.WriteLine($"]");
//     }
// }

// // Решение через int[], return result-----------------------------------------------------------------------------------
// int[] massiv2 = GitArray(7, 0, 5);
// Console.WriteLine($"Первый массив -> [{String.Join(", ", massiv2)}]");
// Console.WriteLine($"Произведение пар чисел в массиве -> [{String.Join(", ", ResultArr(massiv2))}]");


// int[] ResultArr(int[] resarr)
// {
//     int size = resarr.Length / 2;
//     if(resarr.Length % 2 == 1)
//     {
//         size++;
//     }
//     int[] result = new int[size];
//     for (int i = 0; i < resarr.Length / 2; i++)
//     {
//         result[i] = resarr[i] * resarr[resarr.Length - 1 - i ];
//     }
//     if (resarr.Length % 2 == 1)
//     {
//         result[size - 1] = resarr[resarr.Length / 2 ];
//     }
//      return result;
// }


//---------------------------------------------------------- Домашняя работа --------------------------------------------------------------------------------------------------
// // Задача 34: --------------------------------------
// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// //[345, 897, 568, 234] -> 2

//    int EvenNumber(int[] myArray1)
//     {
//         int count = 0;
//         for (int i = 0; i < myArray1.Length; i++)
//         {
//             if (myArray1[i] % 2 == 0)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }

// int[] myArray = GitArray(5, 100, 999);
// Console.WriteLine($"Случайный массив -> [{String.Join(", ", myArray)}]");
// Console.WriteLine($"Количество четных чисел в массиве -> {EvenNumber(myArray)}");
           

// Задача 36: -------------------------
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// // //Вариант первый_______________________________________
// int[] myArray = GitArray(5, -999, 1000);
// Console.WriteLine();
// Console.WriteLine($"[{String.Join(", ", myArray)}] -> {GetSumOdd(myArray)}");
// Console.WriteLine();

// int GetSumOdd(int[]array1)
// {
//     int sum = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//         if(i % 2 !=0) sum = sum + array1[i];
//     }
//         return sum;
// }

// Ответ:  [-827, -556, -708, -566, 744] -> -1122

// //Вариант второй_______________________________________
// int[] myArray = GitArray(5, -999, 1000);
// Console.WriteLine();
// Console.WriteLine($"[{String.Join(", ", myArray)}] -> {SumOfElements(myArray)}");
// Console.WriteLine();

// int SumOfElements(int[]array1)
// {
//     int result = 0;
//     for (int i = 1; i < array1.Length; i = i + 2)
//     {
//         result = result + array1[i];
//     }
//         return result;
// }

// // Ответ   [359, -768, 71, -24, -120, 667] -> -125
// //         [-256, -179, -419, 700, 838] -> 521

// //Вариант третий________________________________________
// int[] myArray1 = GitArray(5, -999, 1000);
// Console.WriteLine($"[{String.Join(", ", myArray1)}]");

// SumOfElements1(myArray1);


// void SumOfElements1(int[]array1)
// {
//     int rezult = 0;
//     for (int i = 1; i < array1.Length; i = i + 2)
//     {
//         rezult = rezult + array1[i];
//     }
//     Console.WriteLine(String.Join("   ", rezult));
// }
// // ОТВЕТ:  [584, -454, 720, 85, 309, 225]
// //         -144                           НЕ СМОГ КРАСИВО ВЫВЕСТИ ОТВЕТ С МЕТОДОМ VOID !!!!!!!!!!!
// //         [376, 120, 456, -919, 643]
// //         -799                           НЕ СМОГ КРАСИВО ВЫВЕСТИ ОТВЕТ С МЕТОДОМ VOID !!!!!!!!!!! 


//Задача 38:-------------------------------------------------------------
//  Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, 
//  с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// //Первый вариант---------------------------------------------------------------
// int[] myArray2 = GitArray(7, -999, 1000);

// Console.WriteLine();
// Console.WriteLine($"Случайный массив -> [{String.Join(", ", myArray2)}]");
// Console.WriteLine($"Разница между максимальным и минимальным элементом: {DifferenceMaxMin(myArray2)}");
// Console.WriteLine();

// int DifferenceMaxMin(int[]myarray)
// {
//     int min = 0;
//     int max = 0;
//     foreach (int i in myarray)  // Поиск максимального и минимального значения
//     {
//         if (min > i) min = i;
//         if (max < i) max = i;
//     }
//     int diff = 0;
//     diff = max - min;
//     return diff;
// }
// // Ответ: Случайный массив -> [-785, 423, 65, -880, 935, -493, 347]
// //        Разница между максимальным и минимальным элементом: 1815

//Второй вариант-------------------------------------------------------------------------

// int[] myArray2 = GitArray(7, -999, 1000);

// Console.WriteLine();
// Console.WriteLine($"Случайный массив -> [{String.Join(", ", myArray2)}]");
// Console.WriteLine($"Разница между максимальным и минимальным элементом: {DifferenceMaxMin(myArray2)}");
// Console.WriteLine();

// int DifferenceMaxMin(int[]myarray)
// {   
//     int nummax = 0;
//     int nummin = 0;
//     for (int i = 0; i < myarray.Length; i++)
//     {
//         if(myarray[i] > nummax)
//         {
//             nummax = myarray[i];
//         }
//         if(myarray[i] < nummin)
//         {
//             nummin = myarray[i];
//         }
//     }
//     int numdiff = 0;
//     numdiff = nummax - nummin;
//     return numdiff;
// }
// Ответ:    Случайный массив -> [-196, 49, -999, -374, 360, 237, 351]
//           Разница между максимальным и минимальным элементом: 1359

//Ватиант третий и ЛУЧШЫЙ, ближе к условию задачи (массив вещественных чисел).

Console.Write("Введите размерность: ");
int m = int.Parse(Console.ReadLine()!);
double[] startArray = new double[m];
FillArray(startArray);
Console.WriteLine($"[ {String.Join(" ", startArray)} ]");
Console.WriteLine($"Разница = {DifferenceMaxMin(startArray):f2}");  // f2 - сокращение до двух цифр после запятой.

void FillArray(double[] matrix)  // т.к. веществееные цыфры имеют вид 0.0; 1.0; и ... , то инициализируем переменную matrix как double.
{
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[i] = new Random().NextDouble(); // и тут по-этому NextDouble, заполняем вещественным числом.
    }
}

double DifferenceMaxMin(double[]array)
{
    double min = 0;
    double max = 0;
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}
// Ответ :  Введите размерность: 5
//          [ 0,7344259557107601 0,09428104393515235 0,7370876064405543 0,4739443138125671 0,8023544622650124 ]
//          Разница = 0,80
