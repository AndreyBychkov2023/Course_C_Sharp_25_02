// Задача 2: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24   5 -> 120.

int IncNum(int num)
{
    int all_inc = 1;
    for (int i = 1; i <= num; i++)
        all_inc *= i;

    return all_inc;
}

int A = int.Parse(Console.ReadLine()!);
int result = IncNum(A);
Console.WriteLine(result);
