// Программа на вход принимает число (может быть любой размерности). Необходимо вывести количество цифр в этом числе.

Console.Write("Введи целое число");
int number = int.Parse(Console.ReadLine());
int count = 1;
if (number > 0)
{
    while (number / 10 > 0)
    {
        count++;
        number = number / 10;
    }
}
else
{
    while (number / -10 > 0)
    {
        count++;
        number = number / 10;
    }
}    
Console.Write($"Количество цифр в числе - {count}");
