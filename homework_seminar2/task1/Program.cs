// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи целое число от 1 до 7 включительно");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case (1):
        Console.WriteLine("Понедельник");
        break;
    case (2):
        Console.WriteLine("Вторник");
        break;
    case (3):
        Console.WriteLine("Среда");
        break;
    case (4):
        Console.WriteLine("Четверг");
        break;
    case (5):
        Console.WriteLine("Пятница");
        break;
    case (6):
        Console.WriteLine("Суббота - Выходной");
        break; 
    case (7):
        Console.WriteLine("Воскресенье - Выходной");
        break;               
    default:
        Console.WriteLine("Такого дня недели не существует");
        break;
}