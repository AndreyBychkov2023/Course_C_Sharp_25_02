//Задача 3: Напишите программу, которая на вход
//принимает число и выдаёт, является ли число
//чётным (делится ли оно на два без остатка).

string s_a = Console.ReadLine()!;

int a = int.Parse(s_a);

if (a % 2 == 0)
{
    Console.WriteLine("Четное");
}

else
{
    Console.WriteLine("Нечетное");
}
