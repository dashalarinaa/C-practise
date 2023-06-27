// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int [5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next (100, 1000);
    Console.WriteLine (array[i]);
}

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
        Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {sum}");
    }
}