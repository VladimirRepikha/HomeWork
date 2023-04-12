// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

int minSumRowIndex = 0;
int minSumRowSum = int.MaxValue;

for (int i = 0; i < arr.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        rowSum += arr[i, j];
    }
    if (rowSum < minSumRowSum)
    {
        minSumRowSum = rowSum;
        minSumRowIndex = i;
    }
}
int rowNumber = minSumRowIndex + 1;
Console.WriteLine($"{rowNumber}-я строка.");
