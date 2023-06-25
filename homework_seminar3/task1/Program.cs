// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());


int i_1 = number / 10000;
int i_5 = number % 10;
int i_2 = (number / 1000) % 10;
int i_4 = (number % 100) / 10;
if (Math.Abs(number) >= 10000 || Math.Abs(number) <=99999)
{
    if (i_1 == i_5 && i_2 == i_4) 
    {
        Console.WriteLine("Число является палиндромом");
    }
    else 
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}