// Задача 1: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

string s_num = Console.ReadLine()!;
int num = int.Parse(s_num);
if (num < 10000) Console.WriteLine("Ошибка, введите пятизначное число");
else if (num > 99999) Console.WriteLine("Ошибка, введите пятизначное число");
else if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10 ) Console.WriteLine("Это палиндром");
else if (num / 10000 < num % 10) Console.WriteLine("Это не палиндром");
