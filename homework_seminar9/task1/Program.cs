//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введи целое число: ");
int number = int.Parse(Console.ReadLine());

int FillNatural(int N)
{
    if (N == 0) return 1;
    Console.WriteLine(N + "");
    int temp = 1 + FillNatural(N-1);

    return temp;
}

FillNatural(number);