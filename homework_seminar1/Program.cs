// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введи первое целое число");
int number = int.Parse(Console.ReadLine());

Console.Write("Введи второе целое число");
int number_2 = int.Parse(Console.ReadLine());

if (number > number_2)
{
    Console.WriteLine($"Число {number} больше числа {number_2}");
}
else
{
    Console.WriteLine($"Число {number_2} больше {number}");
}