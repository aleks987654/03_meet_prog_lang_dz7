// Семинар 7. Рекурсия
// Домашнее задание. Задача 3
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// !!!      Использовать рекурсию, не использовать циклы.

// Функция заполнения массива случайными однозначными числами
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 100);
    }
}

// Функция вывода элементов массива на консоль
void PrintArray(int[] collection)
{
    foreach (int item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

// Функция вывода элементов массива на консоль в обратном порядке
void PrintArrayInReverseOrder(int[] input_arr)
{
    if (input_arr.Length == 0) return;
    // Console.Write($"{input_arr[0]} ");
    int[] array = input_arr[1..];
    PrintArrayInReverseOrder(array);
    Console.Write($"{input_arr[0]} ");
}


// **********     Тело программы     **********
Console.Write("Введите размер массива: ");
string input = Console.ReadLine()!;
int len;
if (int.TryParse(input, out len) && (len > 0))
{
    int[] arr = new int[len];
    FillArray(arr);
    Console.WriteLine("Массив, заполненный случайными числами от 1 до 100:");
    PrintArray(arr);
    Console.WriteLine("Массив в обратном порядке: ");
    PrintArrayInReverseOrder(arr);
}
else
{
    Console.WriteLine("Некорректный ввод");
}
