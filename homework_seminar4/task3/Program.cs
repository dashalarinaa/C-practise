// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


/*
Через Random

int[] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next (0, 10);
    Console.WriteLine (array[i]);
}
*/

int[] array = new int[8];
array[0] = 10;
array[1] = 11;
array[2] = 12;
array[3] = 13;
array[4] = 14;
array[5] = 15;
array[6] = 16;
array[7] = 17;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine (array[i]);
}