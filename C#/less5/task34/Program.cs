﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arr = new int[5];
Random rnd = new Random();

Console.WriteLine("В массиве из: ");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);

    Console.Write(arr[i] + " ");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Чётных чисел: " + count);