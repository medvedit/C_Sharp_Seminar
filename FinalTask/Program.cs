// Первый вариант :
//=====================================================================================================================
string[] array = new string[6] {"473", "-2", "hello", "world", "757t", ":-)"};
string[] result = new string[array.Length];

SecondArray(array, result);
string[]resultFinal = result.Where (x => !string.IsNullOrEmpty(x)).ToArray();
PrintArray(resultFinal);

void SecondArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[count].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] arr3)
{
    for (int i = 0; i < arr3.Length; i++)
    {
        Console.Write($"\"{arr3[i]}\", ");
    }
    Console.WriteLine();
}


// Второй вариант : 
//==================================================================================================================

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите элемены массива:");
string[] firstArray = new string[size];

for (int i = 0; i < size; i++)
{
    firstArray[i] = Console.ReadLine()!;
}

string[] newArray = new string[size];

Massive(size);


Console.WriteLine("Вывод массива: ");
for (int i = 0; i < size; i++)
{
    if (newArray[i] is not null)
    {
        Console.Write($"{newArray[i]}, ");
    }
}

void Massive(int size)
{
    for (int i = 0; i < size; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[i] = firstArray[i];
        }

    }
}
