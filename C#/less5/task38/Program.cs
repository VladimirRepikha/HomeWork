// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] arr = { 3, 7, 22, 2, 78 };

double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    else if (arr[i] < min)
    {
        min = arr[i];
    }
}

double dif = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами: " + dif);