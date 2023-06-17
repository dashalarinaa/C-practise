// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
Console.Write("Введи первое число");
int number = int.Parse(Console.ReadLine());
Console.Write("Введи второе число");
int number_2 = int.Parse(Console.ReadLine());

if (number % number_2 == 0)
{
    Console.Write($"Число {number_2} кратно числу {number}");
}
else
{
    int result = number % number_2;
    Console.Write ($"Остаток от деления первого числа на второе равно {result}");
}