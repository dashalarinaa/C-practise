﻿// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введи целое число ");
int N = int.Parse(Console.ReadLine());
int[] fibon = new int [N];
if (N > 2)
    {
        fibon[0]= 0;
        fibon[1] = 1;

        for (int i = 2; i < fibon.Length; i++) 
            {
                fibon[i] = fibon[i - 2] + fibon[i - 1];
            }
        for (int j = 0; j < fibon.Length; j++)
        {
            Console.Write(fibon[j]+ " ");
        }    
    }
