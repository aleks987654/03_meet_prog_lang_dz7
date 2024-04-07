// Семинар 7. Рекурсия
// Домашнее задание. Задача 1
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа 
// в промежутке от M до N. 
// !!!      Использовать рекурсию, не использовать циклы.

// Функция вывода на консоль всех натуральных чисел от M до N
void SequenceOfNumbers(int stop, int start = 1)
{
    if (stop < start) return;
    SequenceOfNumbers(stop - 1, start);
    Console.Write($"{stop} ");
}

// **********     Тело программы     **********
Console.WriteLine("Введите натуральные числа M и N, при этом M < N");
Console.Write("M: ");
string input_m = Console.ReadLine()!;
Console.Write("N: ");
string input_n = Console.ReadLine()!;
int m;
int n;
if ((int.TryParse(input_m, out m) && (m > 0))
    && (int.TryParse(input_n, out n) && (n > m)))
{
    SequenceOfNumbers(n, m);
}
else
{
    Console.WriteLine("Некорректный ввод");
}
