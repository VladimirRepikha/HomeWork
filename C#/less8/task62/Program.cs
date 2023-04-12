// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] spiralArray = new int[4, 4];

int value = 1;
int rowStart = 0, rowEnd = 3, colStart = 0, colEnd = 3;

while (value <= 16)
{
    for (int i = colStart; i <= colEnd; i++)
    {
        spiralArray[rowStart, i] = value++;
    }
    for (int i = rowStart + 1; i <= rowEnd; i++)
    {
        spiralArray[i, colEnd] = value++;
    }
    for (int i = colEnd - 1; i >= colStart; i--)
    {
        spiralArray[rowEnd, i] = value++;
    }
    for (int i = rowEnd - 1; i >= rowStart + 1; i--)
    {
        spiralArray[i, colStart] = value++;
    }
    rowStart++; rowEnd--; colStart++; colEnd--;
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0,-2} ", spiralArray[i, j]);
    }
    Console.WriteLine();
}
