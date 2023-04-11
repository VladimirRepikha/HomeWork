// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.Write("В какой строке искать? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("В каком столбце искать? ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || m >= array.GetLength(0) || n < 0 || n >= array.GetLength(1))
{
    Console.WriteLine("В указаных координатах ничего не найдено.");
}
else
{
    int element = array[m, n];
    Console.WriteLine($"Значение элемента [{m}, {n}]: {element}");
}