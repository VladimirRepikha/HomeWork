// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[5];
Random rnd = new Random();

Console.WriteLine("В массиве из: ");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-10, 10);

    Console.Write(arr[i] + " ");
}
Console.WriteLine();

int sum = 0;
for (int i = 1; i < arr.Length; i += 2)
{
    sum += arr[i];
}

Console.WriteLine("Сумма элементов на нечётных позициях: {0}", sum);