// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr = new int[3, 4] {{ 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }};

int m = arr.GetLength(0);
int n = arr.GetLength(1);

double[] middle = new double[n];

for (int j = 0; j < n; j++)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += arr[i, j];
    }
    middle[j] = (double)sum / m;
}

for (int j = 0; j < n; j++)
{
    Console.WriteLine(middle[j]);
}
