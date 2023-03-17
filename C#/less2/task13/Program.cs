//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number / 100) % 10;
if (result == 0)
{   
    Console.WriteLine("Введённое число содержит менее трёх цифр.");
}
else
{   
    Console.WriteLine(result);
}
