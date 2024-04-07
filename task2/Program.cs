// Семинар 7. Рекурсия
// Домашнее задание. Задача 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// A(0,m)       = m + 1
// A(n+1,0)     = A(n,1)
// A(n+1, m+1)  = A(n,A(n+1, m))

// Функция вычисления функции Аккермана
int ack(int n, int m)
{
    if (n == 0) return m + 1;

    else
    {
        if (m == 0) return ack(n - 1, 1);
        else return ack(n - 1, ack(n, m - 1));
    }
}

//     while (n != 0)
//     {
//         if (m == 0) m = 1;
//         else m = ack(n, m - 1);
//         n = n - 1;
//     }
//     return m + 1;
//}

// **********     Тело программы     **********
Console.WriteLine("Введите неотрицательные целые числа m и n");
Console.WriteLine("При m = 0 и n > 4 - переполнение стека");
Console.WriteLine("При m = 1 и n > 3 - переполнение стека");
Console.WriteLine("При m = 2 и n > 3 - переполнение стека");
Console.WriteLine("При m = 3 и n > 3 - переполнение стека");
Console.WriteLine("При m = 4 и n > 3 - переполнение стека");
Console.WriteLine("При m = 5 и n > 3 - переполнение стека");
Console.WriteLine("При m > 5  - не моделировал");
Console.WriteLine();
Console.Write("m = ");
string input_m = Console.ReadLine()!;
Console.Write("n = ");
string input_n = Console.ReadLine()!;
int ack_m;
int ack_n;
if ((int.TryParse(input_m, out ack_m) && (ack_m >= 0))
    && (int.TryParse(input_n, out ack_n) && (ack_n >= 0)))
{
    Console.WriteLine(ack(ack_n, ack_m));
}
else
{
    Console.WriteLine("Некорректный ввод");
}

// for (int i = 0; i < 6; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.WriteLine($"m = {i}   n = {j}    A = {ack(j, i)}");
//     }
// }

