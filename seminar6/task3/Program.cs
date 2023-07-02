// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введи целое число ");
int number = int.Parse(Console.ReadLine());
string sum ="";
int step = 0;
while (number > 0)
{
    step = number % 2;
    number = number / 2;
    sum = step + sum;
}
Console.Write($"В двоичной системе число = {sum}");