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

int[] myArray = GitArray(10,0,10);
Console.WriteLine($"[{String.Join(" , ", myArray)}]");

Console.WriteLine($"[{String.Join(" | ", CopyArray(myArray))}]");


int[] CopyArray(int[] arr)
{
    int[] result = new int[arr.Length];  
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i]; 
    }
    return result;  
}
//Ответ : [5 , 2 , 7 , 6 , 3 , 7 , 0 , 3 , 8 , 1]
//        [5 | 2 | 7 | 6 | 3 | 7 | 0 | 3 | 8 | 1]

