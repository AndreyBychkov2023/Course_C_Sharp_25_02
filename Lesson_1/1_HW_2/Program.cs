// Задача 2: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
string s_c = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);

int max = int.Parse(s_a);

 if (a > max)
{
   max = a;
}

if (b > max)
{
   max = b;
}

if (c > max)
{
   max = c;
}

Console.Write("max= ");
Console.WriteLine(max);
