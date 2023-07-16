//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetRecSum(int number)
{
if (number == 0) return 0;
int temp = number % 10 + GetRecSum(number / 10);
return temp;
}
Console.Write("Введи число: ");
int input_number = int.Parse(Console.ReadLine());
Console.WriteLine(GetRecSum(input_number));