// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введи первое целое число");
int number = int.Parse(Console.ReadLine());

Console.Write("Введи второе целое число");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Введи третье целое число");
int number_3 = int.Parse(Console.ReadLine());

if (number > number_2 && number > number_3)
{
    Console.WriteLine($"Число {number} максимальное из предложенных");
}

if (number_2 > number && number_2 > number_3)
{
    Console.WriteLine($"Число {number_2} максимальное из предложенных");
}
else
{
    Console.WriteLine($"Число {number_3} максимальное из предложенных");
}