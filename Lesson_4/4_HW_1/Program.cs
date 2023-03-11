// Задача 1: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);

int IncNum(int a, int b)
{
    int IncNum = 1;
    for (int i = 0; i < b; i++)
        IncNum *= a;
        

    return IncNum;
}

int result = IncNum(a, b);
Console.WriteLine(result);
