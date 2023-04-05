// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

 Console.Write("Введите число: ");
 string str = Console.ReadLine();

 int length = str.Length;
 bool isPalindrome = true;

 for (int i = 0; i < length / 2; i++)
 {
     if (str[i] != str[length - i - 1])
     {
         isPalindrome = false;
         break;
     }
}

if (isPalindrome)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
