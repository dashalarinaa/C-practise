// Напишите программу, которая на вход 
//принимает два числа и проверяет, является ли первое 
//число квадратом второго

Console.Write("Введи первое целое число");
int number = int.Parse(Console.ReadLine());

Console.Write("Введи второе целое число");
int number_2 = int.Parse(Console.ReadLine());

int number_3 = number_2 * number_2;

if (number_3 == number) 
{
    Console.Write("Первое число является квадратом второго");
}
else
{
    Console.Write("Первое число не является квадратом второго");
}