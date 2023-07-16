// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int GetRecSum(int number)
{
if (number == 0) return 0;
int temp = number % 10 + GetRecSum(number / 10);
return temp;
}
Console.Write("Введи число: ");
int input_number = int.Parse(Console.ReadLine());
Console.WriteLine(GetRecSum(input_number));