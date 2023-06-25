// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int number)
{
int i = 1;
int result = 0;
while (number > 0)
{
    result = result + (number % 10);
    number = number / 10;
    i++;
}
return result;
}
Console.Write("Введи число: ");
int input_number = int.Parse(Console.ReadLine());
Console.WriteLine(GetSum(input_number));