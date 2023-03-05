// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.

string s_num = Console.ReadLine()!;
int num = int.Parse(s_num);
if (num<=99)
{
    Console.WriteLine("третьей цифры нет");
}
 while (num > 999) num /= 10;
 Console.WriteLine(num%10);
  
